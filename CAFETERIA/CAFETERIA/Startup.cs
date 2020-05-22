using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CAFETERIA.Startup))]
namespace CAFETERIA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
