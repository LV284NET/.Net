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
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool AddUser(string eMail, string password, string firstName, string lastName)
        {
            if (this.isNewUser((eMail)))
            {
                using (SqlConnection connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                        .ConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertNewUser", connection);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@Email", eMail));
                    command.Parameters.Add(new SqlParameter("@Password", password));
                    command.Parameters.Add(new SqlParameter("@FirstName", firstName));
                    command.Parameters.Add(new SqlParameter("@LastName", lastName));
                    command.Parameters.Add(new SqlParameter("UserID", Guid.NewGuid()));

                    command.ExecuteNonQuery();

                    return true;
                }
            }
            return false;
        }
    }
}