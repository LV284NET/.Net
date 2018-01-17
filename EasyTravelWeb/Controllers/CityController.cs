﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

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
        public IHttpActionResult GetCities()
        {
            IList<City> listToReturn;
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