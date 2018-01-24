using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{

	public class PlaceController : ApiController
	{
		private readonly Logger loger;
		private readonly PlaceRepository placeRepository;

		public PlaceController()
		{
			this.placeRepository = new PlaceRepository();
			this.loger = Logger.GetInstance();
		}
            

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

		[HttpGet]
		[Route("api/Place/GetPlacesPageByCityId")]
		public IHttpActionResult GetPlacesPageByCityId(long cityId, int page)
		{
            try
			{
				List<Place> cityPlaces = this.placeRepository.GetPlacesPage(page, cityId);

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
        /// <param name="favoritePlace"></param>
        /// <returns></returns>
        //[Authorize]
        [HttpPost]
        [Route("api/Place/AddFavoritePlace")]
        public IHttpActionResult AddUserFavouritePlace([FromBody] FavoritePlace favoritePlace)
        {
            try
            {
                if (placeRepository.AddFavouritePlace(favoritePlace.UserId, favoritePlace.PlaceId))
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
        //[Authorize]
        [HttpPost]
        [Route("api/Place/DeleteFavoritePlace")]
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
                this.loger.LogException(ex);
                return InternalServerError();
            }
        }

        //[Route("api/Place/GetPlacesPage")]
        //[HttpGet]
        //public IHttpActionResult GetCities(int page)
        //{

        //    //int getCities = placeRepository.GetPlacesPage(page);
        //    try
        //    {
        //        if (getCities == null)
        //        {
        //            return NotFound();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        loger.LogException(ex);
        //        return InternalServerError();
        //    }

        //    return Ok(getCities);
        //}

    }
}
 
 
