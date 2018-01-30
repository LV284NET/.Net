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

namespace EasyTravelWeb.Repositories
{
    /// <summary>
    ///    
    /// </summary>
    public class PlaceRepository
    {

        /// <summary>
        ///    
        /// </summary>
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
                            PicturePlace = reader["MainPlaceImage"].ToString(),
                            PlaceRating = Convert.ToDouble(reader["PlaceRating"])
                        };
                    }

                    return this.GetPlaceById(new Random().Next(1, 29));
                }
            }
        }

        /// <summary>
        ///    
        /// </summary>
        public double GetPlaceRating(long placeId)
        {
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
        ///    
        /// </summary>
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
                                PlaceId = Convert.ToInt32(reader["PlaceID"]),
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


        internal List<Place> GetPlacesByCityId(long? cityId)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        ///    
        /// </summary>
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
                    }
                    return listToReturn;
                }
            }

            //return null;
        }

        /// <summary>
        ///    
        /// </summary>
        public virtual IList<SearchController.PlaceSearchEntity> GetPlacesIdsAndNames()
        {
            List<SearchController.PlaceSearchEntity> places = new List<SearchController.PlaceSearchEntity>();
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
                            places.Add(new SearchController.PlaceSearchEntity
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
        ///    
        /// </summary>
        public bool AddFavouritePlace(int userId, long placeId)
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
        ///    
        /// </summary>
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
        ///    
        /// </summary>
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
                                PlaceId = Convert.ToInt32(reader["PlaceID"]),
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
        ///    
        /// </summary>
        public int GetCountPlace(long CityId)
        {
            int placesCount = 0;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetCountPlace", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CityID", CityId));


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
    }
}