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
    public class ProfileControllerTest
    {
        private MockRepository _mocks;
        private User user;
        private List<Place> favouritePlaces;

        [SetUp]
        public void initializeForGetFavouritePlaces()
        {
            this._mocks = new MockRepository();

            User user = new User()
            {
                UserId = 1,
                Email = "Some@email.com",
                Password = "Password",
                FirstName = "Name",
                LastName = "LastName"
        
            };

            this.user = user;

        }

        [SetUp]
        public void initializeForGetUserInfo()
        {
            this._mocks = new MockRepository();
            List<Place> places = new List<Place>();

            Place place1 = new Place()
            {
                PlaceId = 1,
                Name = "SomePlace1",
                CityName = "SomeCity",
                Description = "Some description",
                PicturePlace = "Some path to picture"
            };

            Place place2 = new Place()
            {
                PlaceId = 2,
                Name = "SomePlace2",
                CityName = "SomeCity",
                Description = "Some description",
                PicturePlace = "Some path to picture"
            };

            places.Add(place1);
            places.Add(place2);

            this.favouritePlaces = places;

        }


        [Test]
        public void GetUserActionTest()
        {
            var userRepository = _mocks.DynamicMock<UserRepository>();
            var profileController = new ProfileController(userRepository);

            using (_mocks.Record())
            {
                SetupResult.For(userRepository.GetUser(2))
                            .IgnoreArguments()
                            .Return(this.user);
            }

            using (_mocks.Playback())
            {
                IHttpActionResult actual = profileController.GetUser(2);
                Assert.That(actual, Is.TypeOf<OkNegotiatedContentResult<User>>());
            }

        }

        [Test]
        public void GetUserContentTestEmpty()
        {
            var userRepository = _mocks.DynamicMock<UserRepository>();
            var profileController = new ProfileController(userRepository);

            using (_mocks.Record())
            {
                SetupResult.For(userRepository.GetUser(2))
                            .IgnoreArguments()
                            .Return(null);
            }

            using (_mocks.Playback())
            {
                IHttpActionResult actual = profileController.GetUser(2);
                Assert.That(actual, Is.TypeOf<NotFoundResult>());
            }
       
        }

        [Test]
        public void GetFavouritePlacesActionTest()
        {
            var placeRepository = _mocks.DynamicMock<PlaceRepository>();
            var profileController = new ProfileController(placeRepository);

            using (_mocks.Record())
            {
                SetupResult.For(placeRepository.GetFavoritePlaces(2))
                            .IgnoreArguments()
                            .Return(this.favouritePlaces);
            }

            using (_mocks.Playback())
            {
                IHttpActionResult actual = profileController.GetFavoritePlaces(3);
                Assert.That(actual, Is.TypeOf<OkNegotiatedContentResult<List<Place>>>());
            }

        }

        [Test]
        public void GetFavouritePlacesActionTestEmpty()
        {
            var placeRepository = _mocks.DynamicMock<PlaceRepository>();
            var profileController = new ProfileController(placeRepository);

            using (_mocks.Record())
            {
                SetupResult.For(placeRepository.GetFavoritePlaces(2))
                            .IgnoreArguments()
                            .Return(null);
            }

            using (_mocks.Playback())
            {
                IHttpActionResult actual = profileController.GetFavoritePlaces(3);
                Assert.That(actual, Is.TypeOf<NotFoundResult>());
            }

        }
    }
}

