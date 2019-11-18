using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcDynamicNavbar_Demo.Startup))]
namespace MvcDynamicNavbar_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
