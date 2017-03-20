using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHealthCare.Startup))]
namespace WebHealthCare
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
