using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
                    reader.Read();
                    return new Place
                    {
                        Name = reader["name"].ToString(),
                        CityName = reader["cityName"].ToString(),
                        Description = reader["description"].ToString(),
 //                       PicturePlace = new System.Drawing.Bitmap(new MemoryStream((byte[])reader["picture"]))
                    };

                }
            }
        }
    }
}