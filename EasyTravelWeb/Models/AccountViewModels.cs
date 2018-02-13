using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EasyTravelWeb.Models
{
    /// <summary>
    ///    Models returned by AccountController actions.
    /// </summary>

    public class ExternalLoginViewModel
    {
        /// <summary>
        ///    
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string State { get; set; }
    }

    /// <summary>
    ///    
    /// </summary>
    public class ManageInfoViewModel
    {
        /// <summary>
        ///    
        /// </summary>
        public string LocalLoginProvider { get; set; }
 
        /// <summary>
        ///    
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public IEnumerable<UserLoginInfoViewModel> Logins { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public IEnumerable<ExternalLoginViewModel> ExternalLoginProviders { get; set; }
    }

    /// <summary>
    ///    
    /// </summary>
    public class UserInfoViewModel
    {
        /// <summary>
        ///    
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public bool HasRegistered { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string LoginProvider { get; set; }
    }

    /// <summary>
    ///    
    /// </summary>
    public class UserLoginInfoViewModel
    {
        /// <summary>
        ///    
        /// </summary>
        public string LoginProvider { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string ProviderKey { get; set; }
    }
    
    public class FacebookUserViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
    }

}
