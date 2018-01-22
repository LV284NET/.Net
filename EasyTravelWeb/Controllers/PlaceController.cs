using System;
using System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;
using PagedList.Mvc;
using PagedList;

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
		[Route("api/Place/GetPlacesByCityId")]
		public IHttpActionResult GetPlacesByCityId(long cityId, int? page)
		{
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            try
			{
				List<Place> cityPlaces = this.placeRepository.GetPlacesByCityId(cityId);

				if (cityPlaces != null)
				{	
                    return  this.Ok(cityPlaces.ToPagedList(pageNumber, pageSize));
                }

				return this.NotFound();
			}
			catch (Exception ex)
			{
				this.loger.LogException(ex);

				return this.NotFound();
			}

		}
	}
}