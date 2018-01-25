using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Cors;

namespace EasyTravelWeb.App_Start
{
    /// <summary>
    ///    Cors Configuration
    /// </summary>

    public static class CORSConfig
    {
        /// <summary>
        ///    
        /// </summary>

        public static CorsPolicy CorsPolicy = new CorsPolicy
        {
            AllowAnyHeader = true,
            AllowAnyMethod = true,
            SupportsCredentials =  true,
            Origins = {"https://localhost:4200"}
        };
    }
}