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
        public IList<Place> GetPlaces()
        {
            IList<Place> placesForMain=new List<Place>();

            for (int i = 0; i < countMainPlaces; i++)
            {
                try
                {
                    placesForMain.Add(this.placeRepository.GetPlace(new Random().Next(1, 28)));
                }
                catch(Exception ex)
                {
                    this.logger.LogException(ex);
                }
            }

            return placesForMain;
        }

        [System.Web.Http.Route("GetImage")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage GetImage(string placeId)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();

            Image myImage = Image.FromStream(new MemoryStream(this.placeRepository.GetImageById(Convert.ToInt32(placeId))));

            MemoryStream memoryStream = new MemoryStream();

            myImage.Save(memoryStream, ImageFormat.Jpeg);

            httpResponseMessage.Content = new ByteArrayContent(memoryStream.ToArray());
            httpResponseMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
            httpResponseMessage.StatusCode = HttpStatusCode.OK;

            return httpResponseMessage;
        }
    }
}