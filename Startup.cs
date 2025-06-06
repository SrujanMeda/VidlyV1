using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyV1.Startup))]
namespace VidlyV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
