using System.Collections.Generic;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Models;
using NUnit.Framework;

namespace EasyTravelTest
{
    [TestFixture]
    public class HomeControllerTest
    {
        [TestCase]
        public void GetPlacesTest()
        {
            IList<Place> expected = GetPlaces(6);
            var myHomeController = new HomeController();
            IList<Place> actual = myHomeController.GetPlaces();
            Assert.AreEqual(expected.Count, actual.Count);

        }

        public IList<Place> GetPlaces(int countPlaces)
        {
            IList<Place> places = new List<Place>();

            for (int i = 0; i < countPlaces; i++)
            {
                places.Add(new Place { CityName = "city", Description = "description", Name = "place", PlaceId = 1 });
            }

            return places;
        }
    }
}
