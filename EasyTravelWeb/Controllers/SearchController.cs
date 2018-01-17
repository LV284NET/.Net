using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
    [Route("/api/search")]
    public class SearchController : ApiController
    {
        private readonly Logger logger;

        private readonly CityRepository cityRepository;
        private readonly PlaceRepository placeRepository;

        private List<string> names = new List<string>();

        public SearchController()
        {
            logger = Logger.GetInstance();
            cityRepository = new CityRepository();
            placeRepository = new PlaceRepository();

            names.AddRange(cityRepository.GetCitiesNames());
            names.AddRange(placeRepository.GetPlacesNames());
        }

        [Route("se")]
        public IHttpActionResult GetSuggestions(string searchWord)
        {
            try
            {
                List<string> listOfSuggestions = new List<string>();
                names.ForEach(name =>
                {
                    if (name.StartsWith(searchWord))
                    {
                        listOfSuggestions.Add(name);
                    }
                });
                return Ok(listOfSuggestions);
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                return NotFound();
            }
        }
    }
}