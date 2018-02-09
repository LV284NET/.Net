using System.Linq;
using System.Net.Http;
using EasyTravelWeb.Models;
using EasyTravelWeb.Models.BlaBlaCar;

namespace EasyTravelWeb.Services.BlaBlaCar
{
    public class BlaBlaCarResultParser
    {
        public BlaBlaCarResponseModel SuccessResult(HttpResponseMessage response)
        {
            ResponseModel responseModel = response.Content.ReadAsAsync<ResponseModel>().Result;

            return new BlaBlaCarResponseModel
            {
                CountOfSuggestions = responseModel.pager.total,
                TravelTime = responseModel.duration,
                LowestPrice = responseModel.trips.Min().price.value,
                HighestPrice = responseModel.trips.Max().price.value,
                Distance = responseModel.distance,
                Link = responseModel.links._front
            };
        }
    }
}