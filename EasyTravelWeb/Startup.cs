using EasyTravelWeb.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyTravelWeb.Startup))]
namespace EasyTravelWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            ConfigureAuth(app);
        }
    }
}
