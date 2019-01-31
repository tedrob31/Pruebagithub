using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pruebagithub.Startup))]
namespace Pruebagithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
