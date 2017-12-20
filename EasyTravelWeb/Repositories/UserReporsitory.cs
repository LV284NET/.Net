using System.Configuration;
using EasyTravelWeb.Models;
using System.Data.SqlClient;
using System.Data;

namespace EasyTravelWeb.Repositories
{
    public class UserRepository
    {
        public User GetUser(string eMail, string password)
        {
            using (SqlConnection connection=new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"].ConnectionString))
            {
                connection.Open();

                SqlCommand command=new SqlCommand("GetUser", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Email", eMail));
                command.Parameters.Add(new SqlParameter("@Password", password));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    return new User {FirstName = reader["firstName"].ToString(), LastName = reader["lastName"].ToString(), Email = reader["email"].ToString()};
                }
            }
        }
    }
}