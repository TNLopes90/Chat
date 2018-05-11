using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatWebSite.Startup))]
namespace ChatWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
