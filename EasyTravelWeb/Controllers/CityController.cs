using System;
using System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///    Controller for get and set info about cities
    /// </summary>
    public class CityController : ApiController
    {
        private readonly CityRepository cityRepository = new CityRepository();
        private readonly Logger logger = Logger.GetInstance();

        /// <summary>
        ///    Default constructor
        /// </summary>
        public CityController() { }

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
        public IHttpActionResult GetTopCities()
        {
            IList<City> getCities = cityRepository.GetTopCities();
            try
            {
                if (getCities == null)
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                return InternalServerError();
            }

            return Ok(getCities);
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

            IList<City> getCities = cityRepository.GetCitiesPage(page,pageSize);
            try
            {
                if (getCities == null)
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                return InternalServerError();
            }

            return Ok(getCities);
        }

        /// <summary>
        /// Controller for getting City
        /// </summary>
        /// <param name="id">City ID</param>
        /// <returns>Status code with city model</returns>
        [HttpGet]
        public IHttpActionResult GetCity(int id)
        {
            City cityToReturn;
            try
            {
                cityToReturn = cityRepository.GetCity(id);
                if (cityToReturn == null)
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                return InternalServerError();
            }
            return Ok(cityToReturn);
        }

        /// <summary>
        /// Controller for getting count of Cities
        /// </summary>
        /// <returns>Status code with count of cities</returns>
        [HttpGet]
        public IHttpActionResult GetCountCity()
        {
            int cityCount = cityRepository.GetCountCity();
            try
            {
                if (cityCount == 0)
                {
                     return this.NotFound();
                }
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                return InternalServerError();
            }
           return this.Ok(cityCount);
        }
    }
}