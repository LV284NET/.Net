﻿using System.Web.Mvc;
using System.Web.Routing;

namespace EasyTravelWeb
{
    /// <summary>
    ///     RouteConfig
    /// </summary>

    public class RouteConfig
    {
        /// <summary>
        ///    
        /// </summary>

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "MainPage", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}