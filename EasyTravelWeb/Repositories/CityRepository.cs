using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Repositories
{
    public class CityRepository
    {
        private const int pageSize = 3;

        public virtual IList<City> GetCities()
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

        public virtual int GetCitiesPage(int page)
        {
             int citiesCount = 0;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetCitiesPage", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new SqlParameter("@PageNumber", page));
                command.Parameters.Add(new SqlParameter("@PageSize", pageSize));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int currentCityId = Convert.ToInt32(reader["CityID"]);
                            
                          
                        }
                        return citiesCount;
                    }
                }
            }
            return citiesCount;
        }

        public virtual IList<SearchController.CitySearchEntity> GetCitiesIdAndNames()
        {
            List<SearchController.CitySearchEntity> cities = new List<SearchController.CitySearchEntity>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetCitiesIdAndNames", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cities.Add(new SearchController.CitySearchEntity
                            {
                                Id = Convert.ToInt64(reader["CityId"]),
                                Name = reader["CityName"].ToString()
                            });
                        }
                        return cities;
                    }
                }
            }
            return null;
        }

        public virtual City GetCity(long id)
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

        public virtual int GetCountCity(long id)
        {
            int placesCount = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetCountCity", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        placesCount = Convert.ToInt32(reader["Count"]);
                    }
                }
            }
            return placesCount;
        }
    }
}