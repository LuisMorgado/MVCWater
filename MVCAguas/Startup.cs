using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAguas.Startup))]
namespace MVCAguas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
