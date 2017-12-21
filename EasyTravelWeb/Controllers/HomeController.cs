using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
    //[Route("")]
    public class HomeController : Controller
    {
        const int countMainPlaces = 6;

        private readonly PlaceRepository _placeRepository = new PlaceRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("GetPlaces")]
        [HttpGet]
        public List<Place> GetPlaces()
        {
            List<Place> placesForMain=new List<Place>();

            for (int i = 0; i < countMainPlaces; i++)
            {
                placesForMain.Add(_placeRepository.GetPlace(new Random().Next(28)));
            }

            return placesForMain;
        }
    }
}