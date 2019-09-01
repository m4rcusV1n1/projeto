using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoBritaniaWeb.Startup))]
namespace ProjetoBritaniaWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
