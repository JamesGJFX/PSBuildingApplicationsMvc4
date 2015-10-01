using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSmvc4.Startup))]
namespace PSmvc4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
