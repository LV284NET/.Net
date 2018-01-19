using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using EasyTravelWeb.Controllers;
using EasyTravelWeb.Repositories;
using NUnit.Framework;
using Rhino.Mocks;

namespace EasyTravelTest.ControllersTest
{
    [TestFixture]
    class SearchControllerTest
    {
        private MockRepository mockRepository;
        private IList<string> citiesNames;
        private IList<string> placesNames;

        [SetUp]
        public void InitializeSearchEntities()
        {
            mockRepository = new MockRepository();
            citiesNames = new List<string>
            {
                "1City", "2City"
            };
            placesNames = new List<string>
            {
                "1Place", "2Place"
            };
        }
        [TestCase]
        public void GetSuggestionsActionTest()
        {
            CityRepository cityRepository = mockRepository.DynamicMock<CityRepository>();
            PlaceRepository placeRepository = mockRepository.DynamicMock<PlaceRepository>();

            using (mockRepository.Record())
            {
                SetupResult.For(cityRepository.GetCitiesNames()).IgnoreArguments().Return(citiesNames);
                SetupResult.For(placeRepository.GetPlacesNames()).IgnoreArguments().Return(placesNames);
            }

            SearchController searchController = new SearchController(cityRepository, placeRepository);

            using (mockRepository.Playback())
            {
                var suggestions = searchController.GetSuggestions("1");
                Assert.That(suggestions, Is.TypeOf<OkNegotiatedContentResult<IList<SearchController.SearchEntity>>>());
            }
        }

        [TestCase]
        public void GetSuggestionsContentTest()
        {
            CityRepository cityRepository = mockRepository.DynamicMock<CityRepository>();
            PlaceRepository placeRepository = mockRepository.DynamicMock<PlaceRepository>();

            using (mockRepository.Record())
            {
                SetupResult.For(cityRepository.GetCitiesNames()).IgnoreArguments().Return(citiesNames);
                SetupResult.For(placeRepository.GetPlacesNames()).IgnoreArguments().Return(placesNames);
            }

            SearchController searchController = new SearchController(cityRepository, placeRepository);

            using (mockRepository.Playback())
            {
                var suggestions = searchController.GetSuggestions("1") as OkNegotiatedContentResult<IList<SearchController.SearchEntity>>;
                var result = suggestions.Content;
                Assert.That(result.Count, Is.EqualTo(2));
            }
        }
    }
}
