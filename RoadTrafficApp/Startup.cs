using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoadTrafficApp.Startup))]
namespace RoadTrafficApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
