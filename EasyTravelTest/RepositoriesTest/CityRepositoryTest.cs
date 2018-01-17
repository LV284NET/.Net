using System;
using System.Collections.Generic;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;
using NUnit.Framework;

namespace EasyTravelTest.RepositoriesTest
{
    /// <summary>
    /// Summary description for CityRepositoryTest
    /// </summary>
    [TestFixture]
    public class CityRepositoryTest
    {
        [TestCase]
        public void GetCitiesTest()
        {
            CityRepository cityRepository = new CityRepository();
            Assert.AreNotEqual(null, cityRepository.GetCities());
        }

        [TestCase]
        public void GetCityTest()
        {
            CityRepository cityRepository = new CityRepository();
            Assert.AreNotEqual(null, cityRepository.GetCity(new Random().Next(1, 5)));
        }
    }
}
