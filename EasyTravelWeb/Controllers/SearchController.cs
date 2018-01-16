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
    public class SearchController : ApiController
    {
        private readonly Logger logger;

        private readonly CityRepository cityRepository;
        private readonly PlaceRepository placeRepository;

        public SearchController()
        {
            logger = Logger.GetInstance();
            cityRepository = new CityRepository();
            placeRepository = new PlaceRepository();
        }

        //public IHttpActionResult GetSuggestions(string searchWord)
        //{
        //    try
        //    {
        //        List<string> listOfSuggestions = (from city in cityRepository.GetCities()
        //            where city.Name.StartsWith(searchWord)
        //            select city.Name).ToList();
        //        listOfSuggestions.AddRange(from place in placeRepository.GetPlaces()
        //            where place.Name.StartsWith(searchWord)
        //            select place.Name);

        //        if (listOfSuggestions != null)
        //        {
        //            return Ok(listOfSuggestions);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.LogException(ex);
        //        return NotFound();
        //    }
        //}
    }
}