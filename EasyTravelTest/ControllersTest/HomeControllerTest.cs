using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Models;
using NUnit.Framework;

namespace EasyTravelTest
{
    [TestFixture]
    public class HomeControllerTest
    {
        [TestCase]
        public void GetPlacesActionTest()
        {
            var myHomeController = new HomeController();
            IHttpActionResult actual = myHomeController.GetPlaces();
            Assert.That(actual, Is.TypeOf<OkNegotiatedContentResult<IList<Place>>>());
            
        }

        [TestCase]
        public void GetPlacesContentTest()
        {
            var myHomeController = new HomeController();
            
            var placesList = myHomeController.GetPlaces() as OkNegotiatedContentResult<IList<Place>>;

            Assert.IsNotEmpty(placesList.Content);
            Assert.That(placesList.Content.Count, Is.EqualTo(6));
        }
    }
}
