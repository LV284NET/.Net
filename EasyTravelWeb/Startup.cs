using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyTravelWeb.Startup))]
namespace EasyTravelWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
