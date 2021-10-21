using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CinemaRentals2.Startup))]
namespace CinemaRentals2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
