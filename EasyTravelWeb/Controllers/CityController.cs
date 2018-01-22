using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;
using PagedList.Mvc;
using PagedList;

namespace EasyTravelWeb.Controllers
{
    public class CityController : ApiController
    {
        private readonly CityRepository cityRepository = new CityRepository();
        private readonly Logger logger = Logger.GetInstance();

        public CityController() { }

        public CityController(CityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        [Route("api/GetCities")]
        [HttpGet]
        public IHttpActionResult GetCities() //(int? page)
        {
            IList<City> listToReturn;
                int pageSize = 3;
                //int pageNumber = (page ?? 1);
            try
            {
                listToReturn = cityRepository.GetCities();
                if (listToReturn == null)
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                return InternalServerError();
            }
            return Ok(listToReturn);
           // return Ok(listToReturn.ToPagedList(pageNumber, pageSize));
        }

        [Route("api/GetCity")]
        [HttpGet]
        public IHttpActionResult Get(int id)
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
    }
}