using System;
using System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///    
    /// </summary>
    public class CityController : ApiController
    {
        private readonly CityRepository cityRepository = new CityRepository();
        private readonly Logger logger = Logger.GetInstance();

        /// <summary>
        ///    
        /// </summary>
        public CityController() { }

        /// <summary>
        ///    
        /// </summary>
        public CityController(CityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        /// <summary>
        ///    
        /// </summary>
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
        ///    
        /// </summary>
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
        ///    
        /// </summary>
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
        ///    
        /// </summary>
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