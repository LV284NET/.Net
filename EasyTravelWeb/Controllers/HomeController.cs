using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
//using System.Web.UI.WebControls;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;
using System.Drawing;
using System.Net.Http.Headers;

namespace EasyTravelWeb.Controllers
{
    public class HomeController : ApiController
    {
        #region Private Fields

        private readonly PlaceRepository placeRepository = new PlaceRepository();

        private readonly Logger logger = Logger.GetInstance();

        #endregion
        const int countMainPlaces = 6;

        [System.Web.Http.Route("GetPlaces")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetPlaces()
        {
            IList<Place> placesForMain = new List<Place>();

            for (int i = 0; i < countMainPlaces; i++)
            {
                try
                {
                    placesForMain.Add(this.placeRepository.GetPlace(new Random().Next(1, 29)));
                }
                catch(Exception ex)
                {
                    this.logger.LogException(ex);
                    return BadRequest();
                }
            }

            return Ok(placesForMain);
        }
    }
}