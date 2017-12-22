using System;
using  System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
    //[Route("")]
    public class HomeController : ApiController
    {
        const int countMainPlaces = 6;

        private readonly PlaceRepository _placeRepository = new PlaceRepository();
        [Route("GetPlaces")]
        [HttpGet]
        public IList<Place> GetPlaces()
        {
            IList<Place> placesForMain=new List<Place>();

            for (int i = 0; i < countMainPlaces; i++)
            {
                placesForMain.Add(_placeRepository.GetPlace(new Random().Next(28)));
            }

            return placesForMain;
        }
    }
}