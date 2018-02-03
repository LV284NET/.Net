﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Repositories
{
    /// <summary>
    /// Repository for get info about places
    /// </summary>
    public class PlaceRepository
    {
        /// <summary>
        /// get info about place from DataBase
        /// </summary>
        /// <param name="placeId">ID of place</param>
        /// <returns>Info about current place</returns>
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
                            PlaceId = Convert.ToInt64(reader["PlaceID"]),
                            Name = reader["PlaceName"].ToString(),
                            CityName = reader["CityName"].ToString(),
                            Description = reader["PlaceDescription"].ToString(),
                            PicturePlace = reader["MainPlaceImage"].ToString(),
                            PlaceRating = Convert.ToDouble(reader["PlaceRating"])
                        };
                    }

                    return this.GetPlaceById(new Random().Next(1, 29));
                }
            }
        }

        /// <summary>
        /// get rating of place from DataBase
        /// </summary>
        /// <param name="placeId">ID of place</param>
        /// <returns>rating of place</returns>
        public double GetPlaceRating(long placeId)
        {
            List<Place> listToReturn = new List<Place>();

            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("GetPlaceRating", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@PlaceID", placeId));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return Convert.ToDouble(reader["PlaceRating"]);
                    }

                    return 0;
                }
            }
        }

        /// <summary>
        ///		Gets list of places accodring to setected filters
        /// </summary>
        /// <param name="filters">List of filters</param>
        /// <returns>List of places according to list of filters</returns>
        public virtual IList<Place> GetFilteredPlacesPage(int page, long cityId, int pageSize, IList<Filter> filters)
        {
            IList<Place> filteredPlaces = new List<Place>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetFilteredPlaces", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new SqlParameter("@CityID", cityId));
                command.Parameters.Add(new SqlParameter("@PageNumber", page));
                command.Parameters.Add(new SqlParameter("@PageSize", pageSize));

                IEnumerable<int> enumsToIntList = filters.Cast<int>();
                command.Parameters.Add(new SqlParameter("@Filters", string.Join(",", enumsToIntList)));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            filteredPlaces.Add(new Place
                            {
                                PlaceId = Convert.ToInt64(reader["PlaceID"]),
                                Name = reader["PlaceName"].ToString(),
                                Description = reader["PlaceDescription"].ToString(),
                                PicturePlace = reader["MainPlaceImage"].ToString(),
                                CityName = reader["CityName"].ToString(),
                                PlaceRating = Convert.ToDouble(reader["PlaceRating"])
                            });
                        }
                    }
                    return filteredPlaces;
                }
            }
        }

        /// <summary>
        /// get places for page from DataBase
        /// </summary>
        /// <param name="page">number of the page</param>
        /// <param name="cityId">ID of current city</param>
        /// <param name="pageSize">count of place on the page</param>
        /// <returns>list of places</returns>
        public List<Place> GetPlacesPage(int page, long cityId, int pageSize)
        {
            List<Place> listToReturn = new List<Place>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetPlacesPage", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new SqlParameter("@CityID", cityId));
                command.Parameters.Add(new SqlParameter("@PageNumber", page));
                command.Parameters.Add(new SqlParameter("@PageSize", pageSize));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listToReturn.Add(new Place
                            {
                                PlaceId = Convert.ToInt64(reader["PlaceID"]),
                                Name = reader["PlaceName"].ToString(),
                                Description = reader["PlaceDescription"].ToString(),
                                PicturePlace = reader["MainPlaceImage"].ToString(),
                                CityName = reader["CityName"].ToString(),
                                PlaceRating = Convert.ToDouble(reader["PlaceRating"])
                            });
                        }

                        return listToReturn;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// get top places from DataBase
        /// </summary>
        /// <param name="cityId">ID of current city</param>
        /// <returns>list of top places by place rating</returns>
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
	            command.Parameters.Add("@TopPlacesNumber", 4);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listToReturn.Add(new Place
                            {
                                PlaceId = Convert.ToInt64(reader["PlaceID"]),
                                Name = reader["PlaceName"].ToString(),
                                Description = reader["PlaceDescription"].ToString(),
                                PicturePlace = reader["MainPlaceImage"].ToString(),
                                CityName = ""
                            });
                        }
                    }
                    return listToReturn;
                }
            }
        }

        /// <summary>
        /// get id and name of places from DataBase
        /// </summary>
        /// <returns>list of ids and names</returns>
        public virtual IList<PlaceSearchEntity> GetPlacesIdsAndNames()
        {
            List<PlaceSearchEntity> places = new List<PlaceSearchEntity>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetPlacesIdsAndNames", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            places.Add(new PlaceSearchEntity
                            {
                                Id = Convert.ToInt64(reader["PlaceId"]),
                                CityId = Convert.ToInt64(reader["CityId"]),
                                Name = reader["PlaceName"].ToString()
                            });
                        }

                        return places;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// add place to user favorite in DataBase
        /// </summary>
        /// <param name="userId">ID of current user</param>
        /// <param name="placeId">ID of place</param>
        /// <returns>bool value (true if success request, false if fail)</returns>
        public bool AddFavoritePlace(int userId, long placeId)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("InsertNewUserFavoritePlace", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserId", userId));
                command.Parameters.Add(new SqlParameter("@PlaceID", placeId));


                if (command.ExecuteNonQuery() != -1)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// delete place from user favorite in DataBase
        /// </summary>
        /// <param name="userId">ID of current user</param>
        /// <param name="placeId">ID of place</param>
        /// <returns>bool value (true if success request, false if fail)</returns>
        public bool DeleteFavoritePlace(int userId, long placeId)
        {
            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EasyTravelConnectionString"]
                    .ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DeleteUserFavoritePlace", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserId", userId));
                command.Parameters.Add(new SqlParameter("@PlaceID", placeId));


                if (command.ExecuteNonQuery() != 0)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// get user favorite places from DataBase
        /// </summary>
        /// <param name="id">ID of current user</param>
        /// <returns>list of user favorite places</returns>
        public virtual List<Place> GetFavoritePlaces(int id)
        {
            List<Place> favouritePlaces = new List<Place>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetUserFavoritePlaces", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserID", id));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            favouritePlaces.Add(new Place
                            {
                                PlaceId = Convert.ToInt64(reader["PlaceID"]),
                                Name = reader["PlaceName"].ToString(),
                                Description = String.Empty,
                                PicturePlace = reader["MainPlaceImage"].ToString(),
                                CityName = reader["CityName"].ToString(),
                                CityId = Convert.ToInt64(reader["CityID"])
                            });
                        }
                    }
                    return favouritePlaces;
                }
            }
        }

        /// <summary>
        /// get count of places in city
        /// </summary>
        /// <param name="cityId">ID of city</param>
        /// <returns>count of places</returns>
        public int GetCountPlace(long cityId)
        {
            int placesCount = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetCountPlace", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CityID", cityId));


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            placesCount = Convert.ToInt32(reader["Count"]);
                        }
                    }
                    return placesCount;
                }
            }

        }

        /// <summary>
        ///		Method which takes count fo filtered places from databse
        /// </summary>
        /// <param name="filters">Collection of filters, which you want to apply for search</param>
        /// <returns>Count of places</returns>
        public int GetFilteredCountPlace(long cityId, IList<Filter> filters)
        {
            int placesCount = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetCountFromFilteredPlaces", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CityID", cityId));
                IEnumerable<int> enumsToIntList = filters.Cast<int>();
                command.Parameters.Add(new SqlParameter("@Filters", string.Join(",", enumsToIntList)));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            placesCount = Convert.ToInt32(reader["Count"]);
                        }
                    }
                    return placesCount;
                }
            }

        }

        /// <summary>
        ///		Method which takes filter of specific place
        /// </summary>
        /// <returns>list of place filters</returns>
        public IList<int> GetPlaceFilters(long placeId)
        {
            List<int> placeFiltersId = new List<int>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetPlaceFilters", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@PlaceId", placeId));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            placeFiltersId.Add(Convert.ToInt32(reader["FilterId"]));
                        }
                    }
                    return placeFiltersId;
                }
            }

        }
    }
}