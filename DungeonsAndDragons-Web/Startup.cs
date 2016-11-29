using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DungeonsAndDragons_Web.Startup))]
namespace DungeonsAndDragons_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
