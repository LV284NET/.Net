using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Repositories;
using EasyTravelWeb.Models;
using NUnit.Framework;
using Rhino.Mocks;

namespace EasyTravelTest.ControllersTest
{
    [TestFixture]
    public class CityControllerTest
    {
        private MockRepository _mocks;
        private City city;
        private IList<City> cities;

        [SetUp]
        public void initializeForGetCities()
        {
            this._mocks = new MockRepository();
            List<City> cities = new List<City>();

            City city1 = new City()
            {
                Id = 1,
                Name = "SomeCity",
                PicturePath = "Some path to picture",
                Description = "Some description",
            };

            City city2 = new City()
            {
                Id = 2,
                Name = "SomeCity2",
                PicturePath = "Some path to picture2",
                Description = "Some description2",
            };

            cities.Add(city1);
            cities.Add(city2);

            this.cities = cities;
            this.city = city1;

        }


        [Test]
        public void GetCitiesActionTest()
        {
            var cityRepository = _mocks.DynamicMock<CityRepository>();
            var cityController = new CityController(cityRepository);

            using (_mocks.Record())
            {
                SetupResult.For(cityRepository.GetCitiesPage(2,1)).IgnoreArguments().Return(this.cities);
            }

            using (_mocks.Playback())
            {
                IHttpActionResult actual = cityController.GetCities(2,1);
                Assert.That(actual, Is.TypeOf<OkNegotiatedContentResult<IList<City>>>());
            }
          
        }

        [Test]
        public void GetCitiesContentTestNotEmpty()
        {
            var cityRepository = _mocks.DynamicMock<CityRepository>();
            var cityController = new CityController(cityRepository);

            using (_mocks.Record())
            {
                SetupResult.For(cityRepository.GetCitiesPage(1,1)).IgnoreArguments().Return(this.cities);
            }

            using (_mocks.Playback())
            {
                var citiesList = cityController.GetCities(2,1) as OkNegotiatedContentResult<IList<City>>;
                var actual = citiesList.Content;

                Assert.IsNotEmpty(actual);
            }  
        }

        [Test]
        public void GetCitiesContentTestEmpty()
        {
            var cityRepository = _mocks.DynamicMock<CityRepository>();
            var cityController = new CityController(cityRepository);

            using (_mocks.Record())
            {
                SetupResult.For(cityRepository.GetCitiesPage(2,1)).IgnoreArguments().Return(null);
            }

            using (_mocks.Playback())
            {
                IHttpActionResult actual = cityController.GetCities(1,1);
                Assert.That(actual, Is.TypeOf<NotFoundResult>());
            }
        }

        [Test]
        public void GetCityActionTest()
        {
            var cityRepository = _mocks.DynamicMock<CityRepository>();
            var cityController = new CityController(cityRepository);

            using (_mocks.Record())
            {
                SetupResult.For(cityRepository.GetCity(0)).IgnoreArguments().Return(this.city);
            }

            using (_mocks.Playback())
            {
                IHttpActionResult actual = cityController.GetCity(0);
                Assert.That(actual, Is.TypeOf<OkNegotiatedContentResult<City>>());
            }

    }

        [Test]
        public void GetCityContentTestNotNull()
        {
            var cityRepository = _mocks.DynamicMock<CityRepository>();
            var cityController = new CityController(cityRepository);

            using (_mocks.Record())
            {
                SetupResult.For(cityRepository.GetCity(0)).IgnoreArguments().Return(this.city);
            }

            using (_mocks.Playback())
            {
                IHttpActionResult actual = cityController.GetCity(0);
                Assert.IsNotNull(actual);
            }
        }

        [Test]
        public void GetCityContentTestNull()
        {
            var cityRepository = _mocks.DynamicMock<CityRepository>();
            var cityController = new CityController(cityRepository);

            using (_mocks.Record())
            {
                SetupResult.For(cityRepository.GetCity(0)).IgnoreArguments().Return(null);
            }

            using (_mocks.Playback())
            {
                IHttpActionResult actual = cityController.GetCity(0);
                Assert.That(actual,Is.TypeOf<NotFoundResult>());
            }
        }
    }
}
