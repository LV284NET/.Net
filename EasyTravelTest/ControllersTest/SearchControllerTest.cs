using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;
using NUnit.Framework;
using Rhino.Mocks;

namespace EasyTravelTest.ControllersTest
{
    [TestFixture]
    class SearchControllerTest
    {
        private MockRepository mockRepository;
        private IList<CitySearchEntity> cities;
        private IList<PlaceSearchEntity> places;

        [SetUp]
        public void InitializeSearchEntities()
        {
            mockRepository = new MockRepository();
            cities = new List<CitySearchEntity>
            {
                new CitySearchEntity
                {
                    Id = 1, Name = "1City"
                },
                new CitySearchEntity
                {
                    Id = 2, Name = "2City"
                }
            };

            places = new List<PlaceSearchEntity>
            {
                new PlaceSearchEntity
                {
                    Id = 1, CityId = 1, Name = "1Place"
                },
                new PlaceSearchEntity
                {
                    Id = 2, CityId = 2, Name = "2Place"
                }
            };
        }

        [TestCase]
        public void GetSuggestionsActionTest()
        {
            CityRepository cityRepository = mockRepository.DynamicMock<CityRepository>();
            PlaceRepository placeRepository = mockRepository.DynamicMock<PlaceRepository>();

            using (mockRepository.Record())
            {
                SetupResult.For(cityRepository.GetCitiesIdAndNames()).IgnoreArguments().Return(cities);
                SetupResult.For(placeRepository.GetPlacesIdsAndNames()).IgnoreArguments().Return(places);
            }

            SearchController searchController = new SearchController(cityRepository, placeRepository);

            using (mockRepository.Playback())
            {
                var suggestions = searchController.GetSuggestions("1");
                Assert.That(suggestions, Is.TypeOf<OkNegotiatedContentResult<IList<ISearchEntity>>>());
            }
        }

        [TestCase]
        public void GetSuggestionsContentTest()
        {
            CityRepository cityRepository = mockRepository.DynamicMock<CityRepository>();
            PlaceRepository placeRepository = mockRepository.DynamicMock<PlaceRepository>();

            using (mockRepository.Record())
            {
                SetupResult.For(cityRepository.GetCitiesIdAndNames()).IgnoreArguments().Return(cities);
                SetupResult.For(placeRepository.GetPlacesIdsAndNames()).IgnoreArguments().Return(places);
            }

            SearchController searchController = new SearchController(cityRepository, placeRepository);

            using (mockRepository.Playback())
            {
                var suggestions = searchController.GetSuggestions("1") as OkNegotiatedContentResult<IList<ISearchEntity>>;
                var result = suggestions.Content;
                Assert.That(result.Count, Is.EqualTo(2));
            }
        }
    }
}
