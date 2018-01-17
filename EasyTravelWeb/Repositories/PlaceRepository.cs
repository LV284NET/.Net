﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Repositories
{
    public class PlaceRepository
    {
        public Place GetPlaceById(long placeId)
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

					return this.GetPlaceById(new Random().Next(1, 29));
                }
            }
        }

        public List<Place> GetPlacesByCityId(long cityId)
        {
            List<Place> listToReturn = new List<Place>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
	            //TODO: Do not use Stored Procedure, use queries instead.
                SqlCommand command = new SqlCommand("GetPlacesByCityId", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
	            
	            command.Parameters.Add(new SqlParameter("@CityID", cityId));
	            /*
	            var command = new SqlCommand(@"Select * From Place Where CityID = @CityID", connection);
	            command.Parameters.AddWithValue("@CityID", cityId);
	            */
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listToReturn.Add(new Place
                            {
                                PlaceId = Convert.ToInt32(reader["PlaceID"]),
                                Name = reader["PlaceName"].ToString(),
                                Description = reader["PlaceDescription"].ToString(),
                                PicturePlace = reader["MainPlaceImage"].ToString(),
								CityName = reader["CityName"].ToString()
                            });
                        }
                        return listToReturn;
                    }
                }
            }
            return null;
        }

        public List<Place> GetTopPlacesByCityName(string cityName)
        {
	        List<Place> listToReturn = new List<Place>();

			using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetTopPlacesByCityName", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CityName", cityName));

                using (SqlDataReader reader = command.ExecuteReader())
                {
	                if (reader.HasRows)
	                {
		                while (reader.Read())
		                {
			                listToReturn.Add(new Place
			                {
				                PlaceId = Convert.ToInt32(reader["PlaceID"]),
				                Name = reader["PlaceName"].ToString(),
				                Description = reader["PlaceDescription"].ToString(),
				                PicturePlace = reader["MainPlaceImage"].ToString(),
				                CityName = ""
							});
		                }
		                return listToReturn;
	                }
				}
            }
	        return null;
		}

	    public List<Place> GetTopPlacesByCityId(long cityId)
	    {
		    List<Place> listToReturn = new List<Place>();

		    using (SqlConnection connection =
			    new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
				    .ConnectionString))
		    {
			    connection.Open();

			    SqlCommand command = new SqlCommand("GetTopPlacesByCityId", connection);

			    command.CommandType = CommandType.StoredProcedure;

			    command.Parameters.Add(new SqlParameter("@CityID", cityId));

			    using (SqlDataReader reader = command.ExecuteReader())
			    {
				    if (reader.HasRows)
				    {
					    while (reader.Read())
					    {
						    listToReturn.Add(new Place
						    {
							    PlaceId = Convert.ToInt32(reader["PlaceID"]),
							    Name = reader["PlaceName"].ToString(),
							    Description = reader["PlaceDescription"].ToString(),
							    PicturePlace = reader["MainPlaceImage"].ToString(),
								CityName = ""
						    });
					    }
					    return listToReturn;
				    }
			    }
		    }
		    return null;

		}

        public List<Place> GetPlaces()
        {
            List<Place> placesToReturn = new List<Place>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetPlaces", connection);
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            placesToReturn.Add(new Place
                            {
                                PlaceId = Convert.ToInt32(reader["PlaceID"]),
                                Name = reader["PlaceName"].ToString(),
                                Description = reader["PlaceDescription"].ToString(),
                                PicturePlace = reader["MainPlaceImage"].ToString(),
                                CityName = reader["CityName"].ToString()
                            });
                        }
                        return placesToReturn;
                    }
                }
            }
            return null;
        }

        public IList<string> GetPlacesNames()
        {
            List<string> placesNames = new List<string>();
            using(SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetPlacesNames", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            placesNames.Add(reader["PlaceName"].ToString());
                        }
                        return placesNames;
                    }
                }
            }
            return null;
        }
	}	
}