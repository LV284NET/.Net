using System;
using System.Web.Http;
using EasyTravelWeb.Models.BlaBlaCarResponse;
using EasyTravelWeb.Services.BlaBlaCar;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///     Send requests on different services 
    /// </summary>
    public class ServicesController: ApiController
    {
        /// <summary>
        ///  BlaBlaCar Service
        /// </summary>
        private readonly BlaBlaCarService blaBlaCar = new BlaBlaCarService();

        /// <summary>
        /// get info about trips from one city to other city in some date on BlaBlaCar
        /// </summary>
        /// <param name="fromCity">departure city</param>
        /// <param name="toCity">arrival city</param>
        /// <param name="dateOfTrip">Date of trip</param>
        /// <returns>Status code with info about trips</returns>
        [HttpGet]
        public IHttpActionResult GetBlaBlaCarRequestResult(string fromCity, string toCity, DateTime dateOfTrip)
        {
            BlaBlaCarResponseModel resultModel = this.blaBlaCar.BlaBlaCarRequest(fromCity, toCity, dateOfTrip);

            if (resultModel is OKResponse)
                return this.Ok(resultModel);
            return this.BadRequest(((BadResponse)resultModel).error);
        }

        /// <summary>
        /// get info about trips from one city to other city on BlaBlaCar
        /// </summary>
        /// <param name="fromCity">departure city</param>
        /// <param name="toCity">arrival city</param>
        /// <param name="dateOfTrip">Date of trip</param>
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