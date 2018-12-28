using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shop2_videopoint.Startup))]
namespace Shop2_videopoint
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
