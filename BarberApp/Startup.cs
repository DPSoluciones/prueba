using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarberApp.Startup))]
namespace BarberApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
