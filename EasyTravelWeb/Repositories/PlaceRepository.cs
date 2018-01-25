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

        public List<Place> GetPlacesPage(int page, long CityId, int pageSize)
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

                command.Parameters.Add(new SqlParameter("@CityID", CityId));
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
                                CityName = reader["CityName"].ToString()
                            });
                        }

                        return listToReturn;
                    }
                }
            }

            return null;
        }

        public List<Place> GetPlacesByCityId(long cityId)
        {
            List<Place> listToReturn = new List<Place>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager
                .ConnectionStrings["EasyTravelConnectionString"]
                .ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetPlacesByCityId", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

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
                                CityName = reader["CityName"].ToString()
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
                    }
                    return listToReturn;
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
                                CityName = reader["CityName"].ToString()
                            });
                        }

                       
                    }
                    return favouritePlaces;
                }
            }

            return null;
        }

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