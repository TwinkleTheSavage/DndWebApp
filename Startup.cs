using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DndWebApp.Startup))]
namespace DndWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
