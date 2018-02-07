using Microsoft.Owin.Security.OAuth;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using EasyTravelWeb.Infrastructure;

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
            // Web API routes
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            config.Services.Replace(typeof(IExceptionHandler), new GlobalErrorHandling());

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
