using System.Configuration;
using EasyTravelWeb.Models;
using System.Data.SqlClient;
using System.Data;
using System;


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
	                if (!reader.HasRows)
                    {
                        return true;
                    }

	                return false;
                }
            }
        }

        public Guid AddUser(User newUser)
        {
            if (this.isNewUser(newUser.Email))
            {
                using (SqlConnection connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                        .ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertNewUser", connection);

                    command.CommandType = CommandType.StoredProcedure;

	                newUser.UserId = Guid.NewGuid();
                    command.Parameters.Add(new SqlParameter("@Email", newUser.Email));
                    command.Parameters.Add(new SqlParameter("@Password", newUser.Password));
                    command.Parameters.Add(new SqlParameter("@FirstName", newUser.FirstName));
                    command.Parameters.Add(new SqlParameter("@LastName", newUser.LastName));
                    command.Parameters.Add(new SqlParameter("UserID", newUser.UserId));

                    command.ExecuteNonQuery();

                    return newUser.UserId;
                }
            }
            return Guid.Empty;
        }
    }
}