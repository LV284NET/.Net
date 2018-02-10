using System;
using System.Net.Http;
using System.Net.Http.Headers;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Services.BlaBlaCar
{
    public class BlaBlaCarService
    {
        private string urlParameters = "?key=f97db510a2934f3680d9658fe17d54dc&locale=uk_UA&cur=UAH";

        public BlaBlaCarResponseModel BlaBlaCarRequest(string fromCity, string toCity, DateTime travelDate)
        {
            urlParameters = AddParam("fn" ,fromCity);
            urlParameters = AddParam("tn", toCity);
            urlParameters = AddParam("db", travelDate.ToShortDateString());
            urlParameters = AddParam("de", travelDate.ToShortDateString());
            urlParameters = AddParam("limit", "90");
            urlParameters = AddParam("seats", "1");

            HttpResponseMessage message = this.SendRequest(urlParameters);

            if (message.IsSuccessStatusCode)
            {
                BlaBlaCarResultParser parser = new BlaBlaCarResultParser();
                return parser.SuccessResult(message);
            }

            return null;
        }

        public BlaBlaCarResponseModel BlaBlaCarRequest(string fromCity, string toCity)
        {
            urlParameters = AddParam("fn", fromCity);
            urlParameters = AddParam("tn", toCity);
            urlParameters = AddParam("limit", "90");
            urlParameters = AddParam("seats", "1");

            HttpResponseMessage message = this.SendRequest(urlParameters);

            if (message.IsSuccessStatusCode)
            {
                BlaBlaCarResultParser parser = new BlaBlaCarResultParser();
                return parser.SuccessResult(message);
            }

            return null;
        }

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

        private void AddHeaders(HttpClient client, string header, string value)
        {
            client.DefaultRequestHeaders.Add(header, value);   
        }

        private string AddParam(string name, string value)
        {
            return urlParameters + '&' +name + '=' + value;
        }
   }
}