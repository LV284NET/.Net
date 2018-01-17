using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Models;
using NUnit.Framework;

namespace EasyTravelTest.ControllersTest
{
    [TestFixture]
    public class PlaceControllerTest
    {
        [TestCase]
        public void GetPlacesActionTest()
        {
            PlaceController placeController = new PlaceController();
            IHttpActionResult actual = placeController.GetTopPlacesByCityName("Lviv");
            Assert.That(actual, Is.TypeOf<OkNegotiatedContentResult<List<Place>>>());
        }

        [TestCase]
        public void GetPlacesContentTest()
        {
            PlaceController placeController = new PlaceController();

            var placesList = placeController.GetTopPlacesByCityName("Lviv") as OkNegotiatedContentResult<List<Place>>;
            var actual = placesList.Content;

            Assert.IsNotEmpty(actual);
        }

        [TestCase]
        public void GetPlaceActionTest()
        {
            int GetTopPlacesByCityId = 1;
            PlaceController placeController = new PlaceController();

            IHttpActionResult actual = placeController.GetTopPlacesByCityId(GetTopPlacesByCityId);
            Assert.That(actual, Is.TypeOf<OkNegotiatedContentResult<List<Place>>>());
        }

        [TestCase]
        public void GetPlaceContentTest()
        {
            int GetPlaceById = 1;
            PlaceController placeController = new PlaceController();

            var city = placeController.GetPlaceById(GetPlaceById) as OkNegotiatedContentResult<Place>;
            var actual = city.Content;

            Assert.IsNotNull(actual);
        }

    }
}
