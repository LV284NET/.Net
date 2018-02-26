using System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Repositories;
using WebGrease.Css.Extensions;
using EasyTravelWeb.Models.SearchEntities;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///     Controller for search
    /// </summary>
    public class SearchController : ApiController
    {
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
        /// Adds cities to suggestions
        /// </summary>
        /// <param name="searchWord">Key word, which is used to filter names of cities</param>
        /// <param name="listOfSuggestions">List of suggestions according to searchWord</param>
        private void AddCitiesToSuggestions(string searchWord, IList<ISearchEntity> listOfSuggestions)
        {
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
        }

        /// <summary>
        /// Adds places to suggestions
        /// </summary>
        /// <param name="searchWord">Key word, which is used to filter names of places</param>
        /// <param name="listOfSuggestions">List of suggestions according to searchWord</param>
        private void AddPlacesToSuggestions(string searchWord, IList<ISearchEntity> listOfSuggestions)
        {
            int counter = 0;

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
        }

        /// <summary>
        /// Method for getting suggestion according to searchWord
        /// </summary>
        /// <param name="searchWord">Key word, which is used to filter names of cities and places</param>
        /// <returns>List of suggestions according to searchWord</returns>
        [HttpGet]
        public IHttpActionResult GetSuggestions(string searchWord)
        {
            searchWord = searchWord.ToLower();
            IList<ISearchEntity> listOfSuggestions = new List<ISearchEntity>();

            AddCitiesToSuggestions(searchWord, listOfSuggestions);
            AddPlacesToSuggestions(searchWord, listOfSuggestions);

            return this.Ok(listOfSuggestions);
        }
    }
}