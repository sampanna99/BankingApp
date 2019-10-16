using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_ATMDEM.Startup))]
namespace MVC_ATMDEM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
