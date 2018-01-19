using System;
using System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Repositories;
using WebGrease.Css.Extensions;

namespace EasyTravelWeb.Controllers
{
    //[RoutePrefix("api/Search")]
    public class SearchController : ApiController
    {
        private readonly Logger logger = Logger.GetInstance();

        private CityRepository cityRepository = new CityRepository();
        private PlaceRepository placeRepository = new PlaceRepository();

        public class SearchEntity
        {
            public string Name { get; set; }
            public string Type { get; set; }
        }

        private static List<SearchEntity> citiesNames;
        private static List<SearchEntity> placesNames;

        public SearchController() { }

        public SearchController(CityRepository cityRepository, PlaceRepository placeRepository)
        {
	        //this.cityRepository = cityRepository;
	        //this.placeRepository = placeRepository;
		}

        [HttpGet]
        //[Route("GetSuggestions")]
		public IHttpActionResult GetSuggestions(string searchWord)
        {
            try
            {
	            if (citiesNames == null)
	            {
		            citiesNames = new List<SearchEntity>();
		            cityRepository.GetCitiesNames().ForEach(cityName => citiesNames.Add(new SearchEntity
		            {
			            Name = cityName,
			            Type = "City"
		            }));
	            }

	            if (placesNames == null)
	            {
		            placesNames = new List<SearchEntity>();
		            placeRepository.GetPlacesNames().ForEach(placeName => placesNames.Add(new SearchEntity
		            {
			            Name = placeName,
			            Type = "Place"
		            }));
	            }

				IList<SearchEntity> listOfSuggestions = new List<SearchEntity>();
                const int numberToShow = 4;
                int counter = 0;

                foreach (SearchEntity obj in citiesNames)
                {
                    if (obj.Name.StartsWith(searchWord))
                    {
                        listOfSuggestions.Add(obj);
                        if (++counter == numberToShow)
                        {
                            break;
                        }
                    }
                }

                foreach (SearchEntity obj in placesNames)
                {
                    if (obj.Name.StartsWith(searchWord))
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
    }
}