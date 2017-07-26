using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lionelsite.Startup))]
namespace Lionelsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
