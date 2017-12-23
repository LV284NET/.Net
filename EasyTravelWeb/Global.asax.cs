﻿using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace EasyTravelWeb
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}