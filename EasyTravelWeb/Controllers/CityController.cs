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
        public IHttpActionResult GetCities(int page)
        {

            int getCities = cityRepository.GetCitiesPage(page);
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


        [Route("api/GetCountCity")]
        [HttpGet]
        public IHttpActionResult GetCountCity(long Cityid)
        {
            int cityCount = cityRepository.GetCountCity(Cityid);
            try
            {
                if (cityCount == null)
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