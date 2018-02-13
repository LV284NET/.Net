using System;
using System.Net.Http;
using System.Threading.Tasks;
using EasyTravelWeb.Models;
using Newtonsoft.Json;

namespace EasyTravelWeb.Services
{
    public class ExternalLoginVerificator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public async Task<FacebookUserViewModel> VerifyFacebookAccessToken(string accessToken)
        {
            var fbUser = new FacebookUserViewModel();
            var path =
                $"https://graph.facebook.com/v2.12/me?access_token={accessToken}&fields=id,email,first_name,last_name";
            var client = new HttpClient();
            var uri = new HttpRequestMessage();
            uri.RequestUri = new Uri(path);
            var response = await client.SendAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                fbUser = JsonConvert.DeserializeObject<FacebookUserViewModel>(content);
            }

            return fbUser;
        }
    }
}