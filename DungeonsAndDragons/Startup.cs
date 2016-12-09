using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DungeonsAndDragons.Startup))]
namespace DungeonsAndDragons
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
