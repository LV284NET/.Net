using System.Web.Http;
using EasyTravelWeb.Models;
using EasyTravelWeb.Services.BlaBlaCar;

namespace EasyTravelWeb.Controllers
{
    public class ServicesController: ApiController
    {
        private BlaBlaCarService blaBlaCar = new BlaBlaCarService();

        [HttpGet]
        public IHttpActionResult GetBlaBlaCarRequestResult(string fromCity, string toCity, string dateOfTrip)
        {
            BlaBlaCarResponseModel resultModel = this.blaBlaCar.BlaBlaCarRequest(fromCity, toCity, dateOfTrip);

            if (resultModel != null)
                return this.Ok(resultModel);
            return BadRequest();
        }

        [HttpGet]
        public IHttpActionResult GetBlaBlaCarRequestResult(string fromCity, string toCity)
        {
            BlaBlaCarResponseModel resultModel = this.blaBlaCar.BlaBlaCarRequest(fromCity, toCity);

            if (resultModel != null)
                return this.Ok(resultModel);
            return BadRequest();
        }
    }
}