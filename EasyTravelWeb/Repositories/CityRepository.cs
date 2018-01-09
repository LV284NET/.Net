using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Repositories
{
    public class CityRepository
    {
        public IList<City> GetCities()
        {
            List<City> listToReturn = new List<City>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetCities", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int currentCityId = Convert.ToInt32(reader["CityID"]);
                            listToReturn.Add(new City
                            {
                                Id = currentCityId,
                                Name = reader["CityName"].ToString(),
                                Description = reader["CityDescription"].ToString(),
                                PicturePath = reader["CityPhoto"].ToString(),
                            });
                        }
                        return listToReturn;
                    }
                }
            }
            return null;
        }

        public City GetCity(long id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetCityById", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new SqlParameter("@CityID", id));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new City
                        {
                            Id = id,
                            Name = reader["CityName"].ToString(),
                            Description = reader["CityDescription"].ToString(),
                            PicturePath = reader["CityPhoto"].ToString()
                        };
                    }
                }
            }
            return null;
        }
    }
}