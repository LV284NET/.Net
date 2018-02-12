using System;
using System.Net.Http;
using System.Net.Http.Headers;
using EasyTravelWeb.Models.BlaBlaCarResponse;

namespace EasyTravelWeb.Services.BlaBlaCar
{
    /// <summary>
    /// 
    /// </summary>
    public class BlaBlaCarService
    {
        /// <summary>
        /// url with params
        /// </summary>
        private string urlParameters = Constants.Constants.BlaBlaCarResponseConstants.Params;

        /// <summary>
        /// create request with params 
        /// </summary>
        /// <param name="fromCity">departure city</param>
        /// <param name="toCity">arrival city</param>
        /// <param name="travelDate">Date of trip</param>
        /// <returns>info about trips</returns>
        public BlaBlaCarResponseModel BlaBlaCarRequest(string fromCity, string toCity, DateTime travelDate)
        {
            urlParameters = AddParam("fn" ,fromCity);
            urlParameters = AddParam("tn", toCity);
            urlParameters = AddParam("db", travelDate.ToShortDateString());
            urlParameters = AddParam("de", travelDate.ToShortDateString());
            urlParameters = AddParam("limit", "90");
            urlParameters = AddParam("seats", "1");

            using (HttpResponseMessage message = this.SendRequest(urlParameters))
            {
                BlaBlaCarResultParser parser = new BlaBlaCarResultParser();
                if (message.IsSuccessStatusCode)
                {
                    return parser.SuccessResult(message);
                }
                return parser.BadResult(message);
            }
        }

        /// <summary>
        /// create request with params 
        /// </summary>
        /// <param name="fromCity">departure city</param>
        /// <param name="toCity">arrival city</param>
        /// <returns>info about trips</returns>
        public BlaBlaCarResponseModel BlaBlaCarRequest(string fromCity, string toCity)
        {
            urlParameters = AddParam("fn", fromCity);
            urlParameters = AddParam("tn", toCity);
            urlParameters = AddParam("limit", "90");
            urlParameters = AddParam("seats", "1");

            using (HttpResponseMessage message = this.SendRequest(urlParameters))
            {
                BlaBlaCarResultParser parser = new BlaBlaCarResultParser();
                if (message.IsSuccessStatusCode)
                {
                    return parser.SuccessResult(message);
                }
                return parser.BadResult(message);
            }
        }

        /// <summary>
        /// send request with params 
        /// </summary>
        /// <param name="urlParams">url for with params for request</param>
        /// <returns>response from blablacar</returns>
        private HttpResponseMessage SendRequest(string urlParams)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.Constants.BlaBlaCarResponseConstants.URL);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            AddHeaders(client, "Host", "public-api.blablacar.com");
            AddHeaders(client, "User-Agent", "Gelato API Explorer");

            return client.GetAsync(urlParams).Result;
        }

        /// <summary>
        /// add headers to request
        /// </summary>
        /// <param name="client">http client</param>
        /// <param name="header">name of header</param>
        /// <param name="value">value of header</param>
        private void AddHeaders(HttpClient client, string header, string value)
        {
            client.DefaultRequestHeaders.Add(header, value);   
        }

        /// <summary>
        /// create request with params 
        /// </summary>
        /// <param name="name">name of param</param>
        /// <param name="value">value of param</param>
        /// <returns>new url with add params</returns>
        private string AddParam(string name, string value)
        {
            return urlParameters + '&' +name + '=' + value;
        }
   }
}