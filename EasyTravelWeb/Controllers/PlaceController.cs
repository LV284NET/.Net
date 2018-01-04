using EasyTravelWeb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EasyTravelWeb.Controllers
{
    [Route("api/Place")]
    public class PlaceController : ApiController
    {
        private PlaceRepository _placeRepository;
        public PlaceController()
        {
            _placeRepository = new PlaceRepository();
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetPlaceId(int? id)
        {
            if (!id.HasValue) { return BadRequest(); }
            try
            {
                return Ok(_placeRepository.GetPlace(id.Value));
            }
            catch
            {
                return this.NotFound();
            }
        }

        [HttpGet]
        [Route("{name}")]
        public IHttpActionResult GetPlaceName(string name)
        {
            if (name == null) { return BadRequest(); }
            try
            {
                return Ok(_placeRepository.GetPlaceByCytiName(name));
            }
            catch
            {
                return this.NotFound();
            }
        }
    }
}

