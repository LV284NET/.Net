using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;
using Microsoft.AspNet.Identity;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///    
    /// </summary>
    public class PlaceController : ApiController
	{
		private readonly Logger loger;
		private readonly PlaceRepository placeRepository;

	    /// <summary>
	    ///    
	    /// </summary>
        public PlaceController()
		{
			this.placeRepository = new PlaceRepository();
			this.loger = Logger.GetInstance();
		}


        /// <summary>
        ///    
        /// </summary>
		[HttpGet]
		[Route("api/Place/GetPlaceById")]
		public IHttpActionResult GetPlaceById(long placeId)
		{
			try
			{
				return this.Ok(this.placeRepository.GetPlaceById(placeId));
			}
			catch (Exception ex)
			{
				this.loger.LogException(ex);

				return this.NotFound();
			}
		}

	    /// <summary>
	    ///    
	    /// </summary>
		[HttpGet]
		[Route("api/Place/GetTopPlacesByCityName")]
		public IHttpActionResult GetTopPlacesByCityName(string cityName)

		{
			if (cityName == null)
			{
				return this.BadRequest();
			}

			try
			{
				List<Place> cityPlaces = this.placeRepository.GetTopPlacesByCityName(cityName);

				if (cityPlaces != null)
				{
					return this.Ok(cityPlaces);
				}

				return this.NotFound();
			}
			catch (Exception ex)
			{
				this.loger.LogException(ex);

				return this.NotFound();
			}
		}

	    /// <summary>
	    ///    
	    /// </summary>
		[HttpGet]
		[Route("api/Place/GetTopPlacesByCityId")]
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
				this.loger.LogException(ex);

				return this.NotFound();
			}
		}

	    /// <summary>
	    ///    
	    /// </summary>
		[HttpGet]
		[Route("api/Place/GetPlacesPageByCityId")]
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
				this.loger.LogException(ex);

				return this.NotFound();
			}

		}

	    /// <summary>
	    ///    
	    /// </summary>
        [Route("api/Place/GetCountPlaces")]
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
                this.loger.LogException(ex);
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
        [Route("api/Place/AddFavoritePlace")]
        public IHttpActionResult AddUserFavouritePlace([FromBody] Place favoriteUserPlace)
        {
            try
            {
                if (placeRepository.AddFavouritePlace(this.User.Identity.GetUserId<int>(), favoriteUserPlace.PlaceId))
                {
                    return Ok();
                }

                return Content(HttpStatusCode.BadRequest, "You already add this place to favourite");
            }
            catch (Exception ex)
            {
                this.loger.LogException(ex);
                return InternalServerError();
            }
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="favoritePlace"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        [Route("api/Place/DeleteFavoritePlace")]
        public IHttpActionResult DeleteUserFavoritePlace([FromBody] Place favoritePlace)
        {
            try
            {
                if (placeRepository.DeleteFavoritePlace(this.User.Identity.GetUserId<int>(), favoritePlace.PlaceId))
                {
                    return Ok();
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                this.loger.LogException(ex);
                return InternalServerError();
            }
        }
    }
}
 
 
