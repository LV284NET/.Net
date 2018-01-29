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
    /// <summary>
    ///    Repository for get data about City
    /// </summary>

    public class CityRepository
    {

        /// <summary>
        ///    
        /// </summary>
        public virtual IList<City> GetTopCities()
        {
            List<City> listToReturn = new List<City>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetTopCities", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listToReturn.Add(new City
                            {
                                Id = Convert.ToInt64(reader["CityID"]),
                                Name = reader["CityName"].ToString(),
                                Description = reader["CityDescription"].ToString(),
                                PicturePath = reader["CityPhoto"].ToString()
                            });
                        }
                        return listToReturn;
                    }
                }
            }
            return null;
        }

        /// <summary>
        ///    
        /// </summary>
        public virtual IList<City> GetCitiesPage(int page,int pageSize)
        {
             
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

                    IList<City> listToReturn = new List<City>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listToReturn.Add(new City
                            {
                                Id = Convert.ToInt64(reader["CityID"]),
                                Name = reader["CityName"].ToString(),
                                Description = reader["CityDescription"].ToString(),
                                PicturePath = reader["CityPhoto"].ToString(),
                                CityRating =  Convert.ToDouble(reader["CityRating"])
                            }
                            );
                                                   
                        }
                        return listToReturn;
                    }
                }
            }
            return null;
        }

        /// <summary>
        ///    
        /// </summary>
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

        /// <summary>
        ///    
        /// </summary>
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
                            PicturePath = reader["CityPhoto"].ToString(),
                            CityRating = Convert.ToDouble(reader["CityRating"])
                        };
                    }
                }
            }
            return null;
        }

        /// <summary>
        ///    
        /// </summary>
        public virtual int GetCountCity()
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