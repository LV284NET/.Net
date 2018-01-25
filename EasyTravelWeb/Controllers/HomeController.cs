using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;
using System.Drawing;
using System.Net.Http.Headers;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///     Controller for HomePage
    /// </summary>

    public class HomeController : ApiController
    {
        #region Private Fields

        private readonly PlaceRepository placeRepository = new PlaceRepository();

        private readonly Logger logger = Logger.GetInstance();

        #endregion
        private const int CountMainPlaces = 6;

        /// <summary>
        ///    
        /// </summary>
        [System.Web.Http.Route("GetPlaces")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetPlaces()
        {
            IList<Place> placesForMain = new List<Place>();

            for (int i = 0; i < CountMainPlaces; i++)
            {
                try
                {
                    placesForMain.Add(this.placeRepository.GetPlaceById(new Random().Next(1, 29)));
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