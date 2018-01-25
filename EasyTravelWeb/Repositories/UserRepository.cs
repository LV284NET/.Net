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
    /// <summary>
    ///    Repository for get info about User
    /// </summary>

    public class UserRepository
	{
	    /// <summary>
	    ///    
	    /// </summary>
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

        /// <summary>
        /// Method for getting information of specific user from Database
        /// </summary>
        /// <param name="id">ID of current user</param>
        /// <returns>infromation of User(email, First and Last names)</returns>
        public virtual User GetUser(int id)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetUserById", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", id));

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

        /// <summary>
        /// Method For changing First Name of user in database
        /// </summary>
        /// <param name="id">ID of current user</param>
        /// <param name="firstName">New first name of user</param>
        public virtual void ChangeFirstName(int id, string firstName)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("ChangeFirstName", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", id));
                command.Parameters.Add(new SqlParameter("@FirstName", firstName));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                }
            }
        }

        /// <summary>
        /// Method For changing last Name of user in database
        /// </summary>
        /// <param name="id">ID of current user</param>
        /// <param name="lastName">New last name of user</param>
        public virtual void ChangeLastName(int id, string lastName)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("ChangeLastName", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", id));
                command.Parameters.Add(new SqlParameter("@LastName", lastName));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                }
            }
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

	    /// <summary>
	    ///    
	    /// </summary>
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
    }
}