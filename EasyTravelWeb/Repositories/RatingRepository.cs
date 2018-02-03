using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Repositories
{
    /// <summary>
    ///    Repository for get info about user rating
    /// </summary>
    public class RatingRepository
    {
        /// <summary>
        /// set user rating in DataBase
        /// </summary>
        /// <param name="userRating">User Place Rating model (user id, place id, rating)</param>
        /// <returns>bool value(true if success request, false if fail)</returns>
        public bool SetUserRatingForPlace(UserPlaceRating userRating)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("InsertOrUpdateUsersPlaceRating", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserID", userRating.UserId));
                command.Parameters.Add(new SqlParameter("@PlaceID", userRating.PlaceId));
                command.Parameters.Add(new SqlParameter("@Rating", Convert.ToDecimal(userRating.Rating)));

                if (command.ExecuteNonQuery() != -1)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// delete user rating from DataBase
        /// </summary>
        /// <param name="userId">ID of current user</param>
        /// <param name="placeId">ID of place</param>
        /// <returns>bool value(true if success request, false if fail)</returns>
        public bool DeleteUserRatingForPlace(int userId, long placeId)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DeleteUsersPlaceRating", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserID", userId));
                command.Parameters.Add(new SqlParameter("@PlaceID", placeId));

                if (command.ExecuteNonQuery() != -1)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// get user rating of place from DataBase
        /// </summary>
        /// <param name="userId">ID of current user</param>
        /// <param name="placeId">ID of place</param>
        /// <returns>user rating of place</returns>
        public double GetUserRatingOfPlace(int userId, long placeId)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetUserPlaceRating", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserID", userId));
                command.Parameters.Add(new SqlParameter("@PlaceID", placeId));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return Convert.ToDouble(reader["Rating"]);
                    }
                    else
                    {
                        return 0;
                    }
                }

            }
        }
    }
}