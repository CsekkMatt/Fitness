using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitnessBerlet.Startup))]
namespace FitnessBerlet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
