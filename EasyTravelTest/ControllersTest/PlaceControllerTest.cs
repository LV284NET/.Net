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
        public void GetPlaceActionTest()
        {
            int cityId = 1;
	        int numberOfTopPlaces = 4;
            PlaceController placeController = new PlaceController();

            IHttpActionResult actual = placeController.GetTopPlacesByCityId(cityId, numberOfTopPlaces);
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
