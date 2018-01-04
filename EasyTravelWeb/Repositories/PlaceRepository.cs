using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Repositories
{
    public class PlaceRepository
    {
        public Place GetPlace(int placeId)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetPlaceById", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@PlaceID", placeId));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Place
                        {
                            PlaceId = Convert.ToInt32(reader["PlaceID"]),
                            Name = reader["PlaceName"].ToString(),
                            CityName = reader["CityName"].ToString(),
                            Description = reader["PlaceDescription"].ToString(),
                            PicturePlace = reader["MainPlaceImage"].ToString()
                        };
                    }
                    else
                    {
                        return this.GetPlace(new Random().Next(1, 29));
                    }
                }
            }
        }
        public Place GetPlaceByCytiName(string placeName)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetTopPlaceByName", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Place", placeName));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Place
                        {
                            PlaceId = Convert.ToInt32(reader["PlaceID"]),
                            Name = reader["PlaceName"].ToString(),
                            CityName = reader["CityName"].ToString(),
                            Description = reader["PlaceDescription"].ToString(),
                            PicturePlace = reader["MainPlaceImage"].ToString()
                        };
                    }
                    else
                    {
                        return this.GetPlaceByCytiName(placeName);
                    }
                }
            }
        }
    }
}
  