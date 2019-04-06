using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PS_GigHub.Startup))]
namespace PS_GigHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
