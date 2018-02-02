using Microsoft.Owin.Security.OAuth;
using System.Web.Http;

namespace EasyTravelWeb
{
    /// <summary>
    ///    
    /// </summary>

    public static class WebApiConfig
    {
        /// <summary>
        ///    
        /// </summary>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            config.MapHttpAttributeRoutes();
            //config.EnableCors();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
