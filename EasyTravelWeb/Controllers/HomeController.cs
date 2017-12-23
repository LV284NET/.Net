using System;
using  System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
    //[Route("")]
    public class HomeController : ApiController
    {
        #region Private Fields

        private readonly PlaceRepository placeRepository = new PlaceRepository();

        private readonly Logger logger = Logger.GetInstance();

        #endregion
        const int countMainPlaces = 6;

        [System.Web.Http.Route("GetPlaces")]
        [System.Web.Http.HttpGet]
        public IList<Place> GetPlaces()
        {
            IList<Place> placesForMain=new List<Place>();

            for (int i = 0; i < countMainPlaces; i++)
            {
                try
                {
                    placesForMain.Add(this.placeRepository.GetPlace(new Random().Next(28)));
                }
                catch(Exception ex)
                {
                    this.logger.LogExceptionAsync(ex);
                }
            }

            return placesForMain;
        }
    }
}