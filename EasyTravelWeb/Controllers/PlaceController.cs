using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///    Controller model for get info about places 
    /// </summary>
    public class PlaceController : ApiController
	{
		private readonly PlaceRepository placeRepository;

	    /// <summary>
	    ///    Default constructor
	    /// </summary>
        public PlaceController()
		{
			this.placeRepository = new PlaceRepository();
		}

        /// <summary>
        ///    Controller for get info about place
        /// </summary>
        /// <param name="placeId"> ID of current place</param>
        /// <returns>Status code with place model</returns>
		[HttpGet]
		public IHttpActionResult GetPlaceById(long placeId)
		{
				Place place = this.placeRepository.GetPlaceById(placeId);

				if (place != null)
				{
					return this.Ok(place);
				}
				return this.NotFound();
		}

        ///<summary>
        /// Contoller for get rating of place
        /// </summary>
        /// <param name="placeId">ID of current place</param>
        /// <returns>Status code with place rating</returns>
        [HttpGet]
	    public IHttpActionResult GetPlaceRating(long placeId)
	    {
	        return this.Ok(this.placeRepository.GetPlaceRating(placeId));
	    }

	    ///<summary>
	    /// Contoller for get top places of current city
	    /// </summary>
	    /// <param name="cityId">ID of current city</param>
	    /// <returns>Status code with list of top places</returns>
        [HttpGet]
		public IHttpActionResult GetTopPlacesByCityId(long cityId, int numberOfTopPlaces)
		{
			List<Place> cityPlaces = this.placeRepository.GetTopPlacesByCityId(cityId, numberOfTopPlaces);

			if (cityPlaces != null)
			{
				return this.Ok(cityPlaces);
			}
			return this.NotFound();
		}

        ///<summary>
        /// Contoller for get places of some city for some page
        /// </summary>
        /// <param name="cityId">ID of current city</param>
        /// <param name="page">number of the page</param>
        /// <param name="pageSize">Count of places on page</param>
        /// <returns>Status code with places list</returns>
        [HttpGet]
		public IHttpActionResult GetPlacesPageByCityId(long cityId, int page, int pageSize)
		{
			List<Place> cityPlaces = this.placeRepository.GetPlacesPage(page, cityId, pageSize);

			if (cityPlaces != null)
			{	
                return this.Ok(cityPlaces);
            }
			return this.NotFound();
		}

	    /// <summary>
	    /// Controller method for getting filtered places
	    /// </summary>
	    /// <param name="filters">Collection of filters, which you want to apply for search</param>
	    /// <returns>Collection of filtered places</returns>
	    [HttpGet]
	    public IHttpActionResult GetFilteredPlacesByCityId(long cityId, int page, int pageSize, [FromUri]IList<Filter> filters)
	    {
	        IList<Place> filteredPlaces = this.placeRepository.GetFilteredPlacesPage(page, cityId, pageSize, filters);
	        if (filteredPlaces == null)
	        {
	            return this.NotFound();
	        }
	        return this.Ok(filteredPlaces);
	    }

        /// <summary>
        /// Controller method for getting count of filtered places
        /// </summary>
        /// <param name="filters">Collection of filters, which you want to apply for search</param>
        /// <returns>Count of filtered places</returns>
        [HttpGet]
        public IHttpActionResult GetCountFromFilteredPlaces(long cityId, [FromUri]IList<Filter> filters)
        {
            int placeCount = this.placeRepository.GetFilteredCountPlace(cityId,filters);

            if (placeCount == 0)
            {
                return this.NotFound();
            }
            return this.Ok(placeCount);
        }

        /// <summary>
        /// Controller method for filters of specific city
        /// </summary>
        /// <returns>List of filters for specific place</returns>
        [HttpGet]
        public IHttpActionResult GetPlaceFilters(long placeId)
        {
            IList<int> placeFiltersId = this.placeRepository.GetPlaceFilters(placeId);

            if (placeFiltersId == null)
            {
                return this.NotFound();
            }
            return this.Ok(placeFiltersId);
        }

	    /// <summary>
	    /// Controller for get count of places for current city
	    /// </summary>
	    /// <param name="cityId">ID of current city</param>
	    /// <returnsCount of places</returns>
        [HttpGet]
        public IHttpActionResult GetCountPlaces(long cityId)
        {
            int placeCount = this.placeRepository.GetCountPlace(cityId);

            if (placeCount == 0)
            {
                return this.NotFound();
            }
            return this.Ok(placeCount);
        }

        /// <summary>
        /// Controller for add place to favorite by user
        /// </summary>
        /// <param name="favoriteUserPlace">Favorite User Model</param>
        /// <returns>Result of request</returns>
        [Authorize]
        [HttpPost]
        public IHttpActionResult AddUserFavoritePlace([FromBody] FavoritePlace favoriteUserPlace)
        {
            if (this.placeRepository.AddFavoritePlace(favoriteUserPlace.UserId, favoriteUserPlace.PlaceId))
            {
                return this.Ok();
            }
            return this.Content(HttpStatusCode.BadRequest, "You have already added this place to favourite");
        }

	    /// <summary>
	    /// Controller for delete place from favorite by user
	    /// </summary>
	    /// <param name="favoriteUserPlace">Favorite User Model</param>
	    /// <returns>Result of request</returns>
        [Authorize]
        [HttpDelete]
        public IHttpActionResult DeleteUserFavoritePlace([FromBody] FavoritePlace favoritePlace)
        {
            if (this.placeRepository.DeleteFavoritePlace(favoritePlace.UserId, favoritePlace.PlaceId))
            {
                return this.Ok();
            }
            return this.BadRequest();
        }
    }
}
 
 
