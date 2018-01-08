using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Models;
using NUnit.Framework;

namespace EasyTravelTest.ControllersTest
{
    [TestFixture]
    public class CityControllerTest
    {
        [TestCase]
        public void GetCitiesActionTest()
        {
            CityController cityController = new CityController();
            IHttpActionResult actual = cityController.GetCities();
            Assert.That(actual, Is.TypeOf<OkNegotiatedContentResult<IList<City>>>());
        }

        [TestCase]
        public void GetCitiesContentTest()
        {
            CityController cityController = new CityController();

            var citiesList = cityController.GetCities() as OkNegotiatedContentResult<IList<City>>;
            var actual = citiesList.Content;

            Assert.IsNotEmpty(actual);
        }

        [TestCase]
        public void GetCitiyActionTest()
        {
            int cityId = 1;
            CityController cityController = new CityController();

            IHttpActionResult actual = cityController.Get(cityId);
            Assert.That(actual, Is.TypeOf<OkNegotiatedContentResult<City>>());
        }

        [TestCase]
        public void GetCityContentTest()
        {
            int cityId = 1;
            CityController cityController = new CityController();

            var city = cityController.Get(cityId) as OkNegotiatedContentResult<City>;
            var actual = city.Content;

            Assert.IsNotNull(actual);
        }
    }
}
