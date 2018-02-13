using Newtonsoft.Json;

namespace EasyTravelWeb.Models
{
    public class ProviderInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("accesstoken")]
        public string AccessToken { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("provider")]
        public string Provider { get; set; }
    }
}