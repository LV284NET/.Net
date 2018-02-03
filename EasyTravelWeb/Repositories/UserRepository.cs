using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Repositories
{
    /// <summary>
    ///    Repository for get info about User
    /// </summary>

    public class UserRepository
	{
        /// <summary>
        /// Method for getting information of specific user from Database
        /// </summary>
        /// <param name="id">ID of current user</param>
        /// <returns>infromation of User(email, First and Last names)</returns>
        public virtual User GetUser(int id)
        {
            using (SqlConnection connection =
                new SqlConnection(Constants.Constants.ConnectionStrings.DatabaseConnectionString))
            {
                connection.Open();

	            SqlCommand command = new SqlCommand("GetUserById", connection)
	            {
		            CommandType = CommandType.StoredProcedure
	            };

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
                new SqlConnection(Constants.Constants.ConnectionStrings.DatabaseConnectionString))
            {
                connection.Open();

	            SqlCommand command = new SqlCommand("ChangeFirstName", connection)
	            {
		            CommandType = CommandType.StoredProcedure
	            };

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
                new SqlConnection(Constants.Constants.ConnectionStrings.DatabaseConnectionString))
            {
                connection.Open();

	            SqlCommand command = new SqlCommand("ChangeLastName", connection)
	            {
		            CommandType = CommandType.StoredProcedure
	            };


	            command.Parameters.Add(new SqlParameter("@Id", id));
                command.Parameters.Add(new SqlParameter("@LastName", lastName));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                }
            }
        }
    }
}