using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dywizjon.Startup))]
namespace Dywizjon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
