using System;
using System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Repositories;
using WebGrease.Css.Extensions;

namespace EasyTravelWeb.Controllers
{
    public class SearchController : ApiController
    {
        private readonly Logger logger = Logger.GetInstance();

        private readonly CityRepository cityRepository = new CityRepository();
        private readonly PlaceRepository placeRepository = new PlaceRepository();

        private static List<CitySearchEntity> cities;
        private static List<PlaceSearchEntity> placesNames;

        public SearchController()
        {
            InitializeData();
        }

        public SearchController(CityRepository cityRepository, PlaceRepository placeRepository)
        {
            this.cityRepository = cityRepository;
            this.placeRepository = placeRepository;

            InitializeData();
        }

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

                foreach (ISearchEntity obj in placesNames)
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

            if (placesNames == null)
            {
                placesNames = new List<PlaceSearchEntity>();
                placeRepository.GetPlacesIdsAndNames().ForEach(place => placesNames.Add(place));
            }
        }

        public interface ISearchEntity
        {
            long Id { get; set; }
            string Name { get; set; }
            string Type { get; }
        }

        public class CitySearchEntity : ISearchEntity
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public string Type { get; } = "City";
        }

        public class PlaceSearchEntity : ISearchEntity
        {
            public long Id { get; set; }
            public long CityId { get; set; }
            public string Name { get; set; }
            public string Type { get; } = "Place";
        }
    }
}