using System.Linq;
using System.Net.Http;
using EasyTravelWeb.Models.BlaBlaCar;
using EasyTravelWeb.Models.BlaBlaCarResponse;

namespace EasyTravelWeb.Services.BlaBlaCar
{
    /// <summary>
    /// parse response from blablacar 
    /// </summary>
    public class BlaBlaCarResultParser
    {
        /// <summary>
        /// parse response from success result 
        /// </summary>
        /// <param name="response">response from blablacar</param>
        /// <returns>info about trips</returns>
        public OKResponse SuccessResult(HttpResponseMessage response)
        {
            OKResponseModel responseModel = response.Content.ReadAsAsync<OKResponseModel>().Result;

            if (responseModel.pager.total != 0)
            {
                return new OKResponse
                {
                    CountOfSuggestions = responseModel.pager.total,
                    TravelTime = responseModel.duration,
                    LowestPrice = responseModel.trips.Min().price.value,
                    HighestPrice = responseModel.trips.Max().price.value,
                    Distance = responseModel.distance,
                    Link = responseModel.links._front
                };
            }

            return new OKResponse
            {
                CountOfSuggestions = responseModel.pager.total,
                TravelTime = responseModel.duration,
                LowestPrice = 0,
                HighestPrice = 0,
                Distance = responseModel.distance,
                Link = responseModel.links._front
            };
        }

        /// <summary>
        /// parse response from bad result 
        /// </summary>
        /// <param name="response">response from blablacar</param>
        /// <returns>info about error</returns>
        public BadResponse BadResult(HttpResponseMessage response)
        {
            BadResponseModel responseModel = response.Content.ReadAsAsync<BadResponseModel>().Result;

            return new BadResponse
            {
                error = responseModel.error
            };
        }
    }
}