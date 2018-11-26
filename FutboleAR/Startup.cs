using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FutboleAR.Startup))]
namespace FutboleAR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
