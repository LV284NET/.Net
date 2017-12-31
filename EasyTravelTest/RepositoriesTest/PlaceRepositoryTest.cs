using System;
using System.Collections.Generic;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;
using NUnit.Framework;

namespace EasyTravelTest.RepositoriesTest
{
    /// <summary>
    /// Summary description for PlaceRepositoryTest
    /// </summary>
    [TestFixture]
    public class PlaceRepositoryTest
    {
        [TestCase]
        public void GetPlaceTest()
        {
            PlaceRepository placeRepository = new PlaceRepository(); 
            Assert.AreNotEqual(null, placeRepository.GetPlace(new Random().Next(1, 28)));
        }
    }
}
