using System;
using System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Repositories;
using WebGrease.Css.Extensions;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///     Controller for seach
    /// </summary>

    public class SearchController : ApiController
    {
        private readonly Logger logger = Logger.GetInstance();

        private readonly CityRepository cityRepository = new CityRepository();
        private readonly PlaceRepository placeRepository = new PlaceRepository();

        private static List<CitySearchEntity> cities;
        private static List<PlaceSearchEntity> places;

        /// <summary>
        ///    
        /// </summary>
        public SearchController()
        {
            InitializeData();
        }

        /// <summary>
        ///    
        /// </summary>
        public SearchController(CityRepository cityRepository, PlaceRepository placeRepository)
        {
            this.cityRepository = cityRepository;
            this.placeRepository = placeRepository;

            InitializeData();
        }

        /// <summary>
        ///    
        /// </summary>
        [HttpGet]
		public IHttpActionResult GetSuggestions(string searchWord)
        {
            try
            {
                searchWord = searchWord.ToLower();
                IList<ISearchEntity> listOfSuggestions = new List<ISearchEntity>();
                const int numberToShow = 4;
                int counter = 0;
                
                foreach (ISearchEntity obj in cities)
                {
                    if (obj.Name.ToLower().StartsWith(searchWord))
                    {
                        listOfSuggestions.Add(obj);
                        if (++counter == numberToShow)
                        {
                            break;
                        }
                    }
                }

                foreach (ISearchEntity obj in places)
                {
                    if (obj.Name.ToLower().StartsWith(searchWord))
                    {
                        listOfSuggestions.Add(obj);
                        if (++counter == numberToShow + 4)
                        {
                            break;
                        }
                    }
                }
                        
                return Ok(listOfSuggestions);
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                return InternalServerError();
            }
        }

        private void InitializeData()
        {
            if (cities == null)
            {
                cities = new List<CitySearchEntity>();
                cityRepository.GetCitiesIdAndNames().ForEach(city => cities.Add(city));
            }

            if (places == null)
            {
                places = new List<PlaceSearchEntity>();
                placeRepository.GetPlacesIdsAndNames().ForEach(place => places.Add(place));
            }
        }

        /// <summary>
        ///    
        /// </summary>
        public interface ISearchEntity
        {
            /// <summary>
            ///    
            /// </summary>
            long Id { get; set; }

            /// <summary>
            ///    
            /// </summary>
            string Name { get; set; }

            /// <summary>
            ///    
            /// </summary>
            string Type { get; }
        }

        /// <summary>
        ///    
        /// </summary>
        public class CitySearchEntity : ISearchEntity
        {
            /// <summary>
            ///    
            /// </summary>
            public long Id { get; set; }

            /// <summary>
            ///    
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            ///    
            /// </summary>
            public string Type { get; } = "City";
        }

        /// <summary>
        ///    
        /// </summary>
        public class PlaceSearchEntity : ISearchEntity
        {
            /// <summary>
            ///    
            /// </summary>
            public long Id { get; set; }

            /// <summary>
            ///    
            /// </summary>
            public long CityId { get; set; }

            /// <summary>
            ///    
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            ///    
            /// </summary>
            public string Type { get; } = "Place";
        }
    }
}