using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using EasyTravelWeb.Models;
using System.Drawing;
using User = EasyTravelWeb.Models.User;

namespace EasyTravelWeb.Repositories
{
	public class UserRepository
	{
		public User GetUser(string eMail, string password)
		{
			using (SqlConnection connection =
				new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
					.ConnectionString))
			{
				connection.Open();

				SqlCommand command = new SqlCommand("GetUser", connection);

				command.CommandType = CommandType.StoredProcedure;

				command.Parameters.Add(new SqlParameter("@Email", eMail));
				command.Parameters.Add(new SqlParameter("@Password", password));

				using (SqlDataReader reader = command.ExecuteReader())
				{
					reader.Read();
					return new User
					{
						FirstName = reader["firstName"].ToString(),
						LastName = reader["lastName"].ToString(),
						Email = reader["email"].ToString()
					};
				}
			}
		}

		public Guid AddUser(User newObject)
		{
			if (isNewUser(newObject.Email))
				using (SqlConnection connection =
					new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
						.ConnectionString))
				{
					connection.Open();

					SqlCommand command = new SqlCommand("InsertNewUser", connection);

					command.CommandType = CommandType.StoredProcedure;

					do
					{
						newObject.UserId = Guid.NewGuid();
					} while (!checkGuid(newObject.UserId));

					command.Parameters.Add(new SqlParameter("@Email", newObject.Email));
					command.Parameters.Add(new SqlParameter("@Password", newObject.Password));
					command.Parameters.Add(new SqlParameter("@FirstName", newObject.FirstName));
					command.Parameters.Add(new SqlParameter("@LastName", newObject.LastName));
					command.Parameters.Add(new SqlParameter("@IsAdmin", false));
					command.Parameters.Add(new SqlParameter("UserID", newObject.UserId));

					command.ExecuteNonQuery();

					return newObject.UserId;
				}

			return Guid.Empty;
		}

		private bool isNewUser(string eMail)
		{
			using (SqlConnection connection =
				new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
					.ConnectionString))
			{
				connection.Open();

				SqlCommand command = new SqlCommand("isNewUser", connection);

				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add(new SqlParameter("@Email", eMail));

				using (SqlDataReader reader = command.ExecuteReader())
				{
					if (!reader.HasRows) return true;

					return false;
				}
			}
		}

		private bool checkGuid(Guid userGuid)
		{
			using (SqlConnection connection =
				new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
					.ConnectionString))
			{
				connection.Open();

				SqlCommand command = new SqlCommand("isNewGUID", connection);

				command.CommandType = CommandType.StoredProcedure;

				command.Parameters.Add(new SqlParameter("@guid", userGuid));

				using (SqlDataReader reader = command.ExecuteReader())
				{
					if (!reader.HasRows) return true;

					return false;
				}
			}
		}

	    public List<Place> GetPlaces(Guid userGuid)
	    {
	        using (SqlConnection connection =
	            new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
	                .ConnectionString))
	        {
	            connection.Open();

	            SqlCommand command = new SqlCommand("GetUserFavouritePlaces", connection);

	            command.CommandType = CommandType.StoredProcedure;

	            command.Parameters.Add(new SqlParameter("@userGUID", userGuid));

	            using (SqlDataReader reader = command.ExecuteReader())
	            {
                    List<Place> favoritePlaces=new List<Place>();
	                while (reader.Read())
	                {
                       
	                    favoritePlaces.Add(
                            new Place
                            {
                                Name = reader["name"].ToString(),
                                CityName = reader["cityName"].ToString(),
                                Description = reader["description"].ToString(),
                          //      PicturePlace = Image.FromStream(new MemoryStream((byte[])reader["picture"]))
                            });
	                }
	                return favoritePlaces;
	            }
	        }
        }

	    public void AddFavouritePlace(Guid userGuid, int placeId)
	    {
	        using (SqlConnection connection =
	            new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
	                .ConnectionString))
	        {
	            connection.Open();

	            SqlCommand command = new SqlCommand("InsertNewFavourite", connection);

	            command.CommandType = CommandType.StoredProcedure;

	            command.Parameters.Add(new SqlParameter("@userGUID", userGuid));
	            command.Parameters.Add(new SqlParameter("@placeID", placeId));

	            command.ExecuteNonQuery();
	        }
        }
    }
}