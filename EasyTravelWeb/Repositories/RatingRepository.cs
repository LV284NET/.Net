using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http.Results;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Models;
using Microsoft.AspNet.Identity;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Repositories
{
    /// <summary>
    ///    
    /// </summary>
    public class RatingRepository
    {
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
        ///    
        /// </summary>
        public double GetUserRatingOfPlace(int UserId, long PlaceId)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetUserPlaceRating", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserID", UserId));
                command.Parameters.Add(new SqlParameter("@PlaceID", PlaceId));

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