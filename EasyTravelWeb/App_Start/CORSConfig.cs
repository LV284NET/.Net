using System.Web.Cors;

namespace EasyTravelWeb
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
            Origins = {Constants.Constants.CORSConstants.FrontEndUrl}
        };
    }
}