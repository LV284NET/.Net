﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///    
    /// </summary>
    public class PlaceController : ApiController
	{
		private readonly Logger logger;
		private readonly PlaceRepository placeRepository;

	    /// <summary>
	    ///    
	    /// </summary>
        public PlaceController()
		{
			this.placeRepository = new PlaceRepository();
			this.logger = Logger.GetInstance();
		}


        /// <summary>
        ///    
        /// </summary>
		[HttpGet]
		public IHttpActionResult GetPlaceById(long placeId)
		{
			try
			{
				return this.Ok(this.placeRepository.GetPlaceById(placeId));
			}
			catch (Exception ex)
			{
				this.logger.LogException(ex);

				return this.NotFound();
			}
		}
            
	    [HttpGet]
	    public IHttpActionResult GetPlaceRating(long placeId)
	    {
	        try
	        {
	            return this.Ok(this.placeRepository.GetPlaceRating(placeId));
	        }
	        catch (Exception ex)
	        {
	            this.logger.LogException(ex);

	            return this.NotFound();
	        }
	    }

        /// <summary>
        ///    
        /// </summary>
        [HttpGet]
		public IHttpActionResult GetTopPlacesByCityId(long cityId)
		{
			try
			{
				List<Place> cityPlaces = this.placeRepository.GetTopPlacesByCityId(cityId);

				if (cityPlaces != null)
				{
					return this.Ok(cityPlaces);
				}

				return this.NotFound();
			}
			catch (Exception ex)
			{
				this.logger.LogException(ex);

				return this.NotFound();
			}
		}

	    /// <summary>
	    ///    
	    /// </summary>
		[HttpGet]
		public IHttpActionResult GetPlacesPageByCityId(long cityId, int page, int pageSize)
		{
            try
			{
				List<Place> cityPlaces = this.placeRepository.GetPlacesPage(page, cityId, pageSize);

				if (cityPlaces != null)
				{	
                    return  this.Ok(cityPlaces);
                }

				return this.NotFound();
			}
			catch (Exception ex)
			{
				this.logger.LogException(ex);

				return this.NotFound();
			}

		}

	    /// <summary>
	    /// Controller method for getting filtered places
	    /// </summary>
	    /// <param name="filters">Collection of filters, which you want to apply for search</param>
	    /// <returns>Collection of filtered places</returns>
	    [HttpGet]
	    public IHttpActionResult GetFilteredPlacesByCityId(long cityId, int page, int pageSize, [FromUri]IList<Filter> filters)
	    {
	        try
	        {
	            IList<Place> filteredPlaces = placeRepository.GetFilteredPlacesPage(page, cityId, pageSize, filters);
	            if (filteredPlaces == null)
	            {
	                return NotFound();
	            }
	            return Ok(filteredPlaces);
	        }
	        catch (Exception ex)
	        {
	            logger.LogException(ex);
	            return InternalServerError();
	        }
	    }


        /// <summary>
        /// Controller method for getting count of filtered places
        /// </summary>
        /// <param name="filters">Collection of filters, which you want to apply for search</param>
        /// <returns>Count of filtered places</returns>
        [HttpGet]
        public IHttpActionResult GetCountFromFilteredPlaces(long cityId, [FromUri]IList<Filter> filters)
        {
            int placeCount = placeRepository.GetFilteredCountPlace(cityId,filters);
            try
            {
                if (placeCount == 0)
                {
                    return this.NotFound();
                }
                return this.Ok(placeCount);
            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);
                return InternalServerError();
            }
            
        }

        /// <summary>
        /// Controller method for filters of specific city
        /// </summary>
        /// <returns>List of filters for specific place</returns>
        [HttpGet]
        public IHttpActionResult GetPlaceFilters(long placeId)
        {
            IList<int> placeFiltersId = placeRepository.GetPlaceFilters(placeId);
            try
            {
                if (placeFiltersId == null)
                {
                    return this.NotFound();
                }
                return this.Ok(placeFiltersId);
            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);
                return InternalServerError();
            }

        }

        /// <summary>
        ///    
        /// </summary>
        [HttpGet]
        public IHttpActionResult GetCountPlaces(long cityId)
        {
            int placeCount = placeRepository.GetCountPlace(cityId);
            try
            {
                if (placeCount == 0)
                {
                    return this.NotFound();
                }
            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);
                return InternalServerError();
            }
            return this.Ok(placeCount);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="favoriteUserPlace"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public IHttpActionResult AddUserFavoritePlace([FromBody] FavoritePlace favoriteUserPlace)
        {
            try
            {
                if (placeRepository.AddFavoritePlace(favoriteUserPlace.UserId, favoriteUserPlace.PlaceId))
                {
                    return Ok();
                }

                return Content(HttpStatusCode.BadRequest, "You already add this place to favourite");
            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);
                return InternalServerError();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="favoritePlace"></param>
        /// <returns></returns>
        [Authorize]
        [HttpDelete]
        public IHttpActionResult DeleteUserFavoritePlace([FromBody] FavoritePlace favoritePlace)
        {
            try
            {
                if (placeRepository.DeleteFavoritePlace(favoritePlace.UserId, favoritePlace.PlaceId))
                {
                    return Ok();
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);
                return InternalServerError();
            }
        }
    }
}
 
 
