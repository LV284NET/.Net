using System;
using System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;
//using System.Web.UI.WebControls;

namespace EasyTravelWeb.Controllers
{
	public class HomeController : ApiController
	{
		private const int countMainPlaces = 6;

		#region Private Fields

		private readonly PlaceRepository placeRepository = new PlaceRepository();

		private readonly Logger logger = Logger.GetInstance();

		#endregion


		[Route("GetPlaces")]
		[HttpGet]
		public IHttpActionResult GetPlaces()
		{
			IList<Place> placesForMain = new List<Place>();

			for (var i = 0; i < countMainPlaces; i++)
				try
				{
					placesForMain.Add(this.placeRepository.GetPlace(new Random().Next(1, 29)));
				}
				catch (Exception ex)
				{
					this.logger.LogException(ex);
					return this.BadRequest();
				}

			return this.Ok(placesForMain);
		}
	}
}