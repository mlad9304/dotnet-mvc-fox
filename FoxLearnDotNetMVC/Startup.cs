using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoxLearnDotNetMVC.Startup))]
namespace FoxLearnDotNetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
