using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Factory.StoreWeb.Startup))]
namespace Factory.StoreWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
