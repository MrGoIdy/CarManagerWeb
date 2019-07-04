using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarManagerWeb.Startup))]
namespace CarManagerWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
