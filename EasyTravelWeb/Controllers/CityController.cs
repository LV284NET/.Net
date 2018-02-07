using System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
    /// <inheritdoc />
    /// <summary>
    ///    Controller for get and set info about cities
    /// </summary>
    public class CityController : ApiController
    {
        private readonly CityRepository cityRepository = new CityRepository();

        /// <inheritdoc />
        /// <summary>
        ///    Default constructor
        /// </summary>
        public CityController() { }

        /// <inheritdoc />
        /// <summary>
        ///    Constructor with params
        /// </summary>
        /// <params name="cityRepository"> Repository for get info about cities</params>
        public CityController(CityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        /// <summary>
        ///    Controller for getting Top of Cities
        /// </summary>
        /// <returns>Status code with top cities</returns>
        [HttpGet]
        public IHttpActionResult GetTopCities(int numberOfTopCities)
        {
            IList<City> getCities = this.cityRepository.GetTopCities(numberOfTopCities);
            if (getCities == null)
            {
                return this.NotFound();
            }
            return this.Ok(getCities);
        }

        /// <summary>
        /// Controller for getting Cities
        /// </summary>
        /// <param name="page">number of current page</param>
        /// <param name="pageSize">Count of cities on the page</param>
        /// <returns>Status code with list of cities</returns>
        [HttpGet]
        public IHttpActionResult GetCities(int page, int pageSize)
        { 
            IList<City> getCities = this.cityRepository.GetCitiesPage(page, pageSize);
            if (getCities == null)
            {
                return this.NotFound();
            }
            return this.Ok(getCities);
        }

        /// <summary>
        /// Controller for getting City
        /// </summary>
        /// <param name="id">City ID</param>
        /// <returns>Status code with city model</returns>
        [HttpGet]
        public IHttpActionResult GetCity(int id)
        {
            City cityToReturn = this.cityRepository.GetCity(id);
            if (cityToReturn == null)
            {
                return this.NotFound();
            }
            return this.Ok(cityToReturn);
        }

        /// <summary>
        /// Controller for getting count of Cities
        /// </summary>
        /// <returns>Status code with count of cities</returns>
        [HttpGet]
        public IHttpActionResult GetCountCity()
        {
            int cityCount = this.cityRepository.GetCountCity();

            if (cityCount == 0)
            {
                    return this.NotFound();
            }
            return this.Ok(cityCount);
        }
    }
}