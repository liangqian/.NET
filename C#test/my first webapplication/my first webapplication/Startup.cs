using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(my_first_webapplication.Startup))]
namespace my_first_webapplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
