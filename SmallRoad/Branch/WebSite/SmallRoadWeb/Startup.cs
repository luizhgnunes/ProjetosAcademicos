using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmallRoadWeb.Startup))]
namespace SmallRoadWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app); // teste de commit RODRIGO
        }
    }
}
