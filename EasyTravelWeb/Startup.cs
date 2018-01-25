using EasyTravelWeb.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyTravelWeb.Startup))]
namespace EasyTravelWeb
{
    /// <summary>
    ///    
    /// </summary>

    public partial class Startup
    {
        /// <summary>
        ///    
        /// </summary>
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            ConfigureAuth(app);
        }
    }
}
