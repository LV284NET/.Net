using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http.Results;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Models;
using Microsoft.AspNet.Identity;
using WebGrease.Css.Extensions;

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
                            PlaceId = Convert.ToInt64(reader["PlaceID"]),
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
                                PlaceId = Convert.ToInt64(reader["PlaceID"]),
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

        /// <summary>
        /// Gets list of places accodring to setected filters
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
                            });
                        }
                    }
                    return filteredPlaces;
                }
            }
        }

        /// <summary>
        ///    
        /// </summary>
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
                                PlaceId = Convert.ToInt64(reader["PlaceID"]),
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

        /// <summary>
        ///    
        /// </summary>
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
                                PlaceId = Convert.ToInt64(reader["PlaceID"]),
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

            //return null;
        }

        /// <summary>
        ///    
        /// </summary>
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
                                PlaceId = Convert.ToInt64(reader["PlaceID"]),
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
        ///    
        /// </summary>
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
        /// Method which takes count fo filtered places from databse
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
                command.Parameters.Add(new SqlParameter("@Filters", string.Join(",", filters)));

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