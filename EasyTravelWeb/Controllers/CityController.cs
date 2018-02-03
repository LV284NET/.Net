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
        public IHttpActionResult GetTopCities(int numberOfTopCities)
        {
            IList<City> getCities = this.cityRepository.GetTopCities(numberOfTopCities);
            try
            {
                if (getCities == null)
                {
                    return this.NotFound();
                }
            }
            catch (Exception ex)
            {
	            this.logger.LogException(ex);
                return this.InternalServerError();
            }

            return this.Ok(getCities);
        }

        /// <summary>
        ///    
        /// </summary>
        [HttpGet]
        public IHttpActionResult GetCities(int page, int pageSize)
        {

            IList<City> getCities = this.cityRepository.GetCitiesPage(page,pageSize);
            try
            {
                if (getCities == null)
                {
                    return this.NotFound();
                }
            }
            catch (Exception ex)
            {
	            this.logger.LogException(ex);
                return this.InternalServerError();
            }

            return this.Ok(getCities);
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
                cityToReturn = this.cityRepository.GetCity(id);
                if (cityToReturn == null)
                {
                    return this.NotFound();
                }
            }
            catch (Exception ex)
            {
	            this.logger.LogException(ex);
                return this.InternalServerError();
            }
            return this.Ok(cityToReturn);
        }

        /// <summary>
        ///    
        /// </summary>
        [HttpGet]
        public IHttpActionResult GetCountCity()
        {
            int cityCount = this.cityRepository.GetCountCity();
            try
            {
                if (cityCount == 0)
                {
                     return this.NotFound();
                }
            }
            catch (Exception ex)
            {
	            this.logger.LogException(ex);
                return this.InternalServerError();
            }
           return this.Ok(cityCount);
        }
    }
}