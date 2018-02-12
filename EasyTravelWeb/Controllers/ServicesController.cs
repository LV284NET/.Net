using System;
using System.Web.Http;
using EasyTravelWeb.Models.BlaBlaCarResponse;
using EasyTravelWeb.Services.BlaBlaCar;

namespace EasyTravelWeb.Controllers
{
    public class ServicesController: ApiController
    {
        private BlaBlaCarService blaBlaCar = new BlaBlaCarService();

        [HttpGet]
        public IHttpActionResult GetBlaBlaCarRequestResult(string fromCity, string toCity, DateTime dateOfTrip)
        {
            BlaBlaCarResponseModel resultModel = this.blaBlaCar.BlaBlaCarRequest(fromCity, toCity, dateOfTrip);

            if (resultModel is OKResponse)
                return this.Ok(resultModel);
            return this.BadRequest(((BadResponse)resultModel).error);
        }

        [HttpGet]
        public IHttpActionResult GetBlaBlaCarRequestResult(string fromCity, string toCity)
        {
            BlaBlaCarResponseModel resultModel = this.blaBlaCar.BlaBlaCarRequest(fromCity, toCity);

            if (resultModel is OKResponse)
                return this.Ok(resultModel);
            return this.BadRequest(((BadResponse)resultModel).error);

        }
    }
}