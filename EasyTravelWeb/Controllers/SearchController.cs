using System;
using System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Repositories;
using WebGrease.Css.Extensions;
using EasyTravelWeb.Models;
using EasyTravelWeb.Models.SearchEntities;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///     Controller for search
    /// </summary>
    public class SearchController : ApiController
    {
        private readonly Logger logger = Logger.GetInstance();

        private readonly CityRepository cityRepository = new CityRepository();
        private readonly PlaceRepository placeRepository = new PlaceRepository();

        private static List<CitySearchEntity> cities;
        private static List<PlaceSearchEntity> places;

        /// <summary>
        ///    Default constructor
        /// </summary>
        public SearchController()
        {
	        this.InitializeData();
        }

        /// <summary>
        ///    Constructor with parameters for unit testing
        /// </summary>
        public SearchController(CityRepository cityRepository, PlaceRepository placeRepository)
        {
            this.cityRepository = cityRepository;
            this.placeRepository = placeRepository;

	        this.InitializeData();
        }

        /// <summary>
        /// Initialization of cities and places fields, if they are null
        /// </summary>
        private void InitializeData()
        {
            if (cities == null)
            {
                cities = new List<CitySearchEntity>();
	            this.cityRepository.GetCitiesIdAndNames().ForEach(city => cities.Add(city));
            }

            if (places == null)
            {
                places = new List<PlaceSearchEntity>();
	            this.placeRepository.GetPlacesIdsAndNames().ForEach(place => places.Add(place));
            }
        }

        /// <summary>
        /// Method for getting suggestion according to searchWord
        /// </summary>
        /// <param name="searchWord">Key word, which is used to filter names of cities and places</param>
        /// <returns>List of suggestions according to searchWord</returns>
        [HttpGet]
		public IHttpActionResult GetSuggestions(string searchWord)
        {
            try
            {
                searchWord = searchWord.ToLower();
                IList<ISearchEntity> listOfSuggestions = new List<ISearchEntity>();

                int counter = 0;
                
                foreach (ISearchEntity obj in cities)
                {
                    if (obj.Name.ToLower().Contains(searchWord))
					{
                        listOfSuggestions.Add(obj);
                        if (++counter == Constants.Constants
	                            .SearchControllerConstants.NumberOfSearchEntitiesToShow)
                        {
                            break;
                        }
                    }
                }

	            counter = 0;

				foreach (ISearchEntity obj in places)
                {
                    if (obj.Name.ToLower().Contains(searchWord))
                    {
                        listOfSuggestions.Add(obj);

                        if (++counter == Constants.Constants
	                            .SearchControllerConstants.NumberOfSearchEntitiesToShow)
                        {
                            break;
                        }
                    }
                }
                        
                return this.Ok(listOfSuggestions);
            }
            catch (Exception ex)
            {
	            this.logger.AsyncLogException(ex);
                return this.InternalServerError();
            }
        }
    }
}