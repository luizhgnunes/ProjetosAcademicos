using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmallRoad.Startup))]
namespace SmallRoad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app); // vai
        }
    }
}
