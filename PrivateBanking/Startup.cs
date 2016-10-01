using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrivateBanking.Startup))]
namespace PrivateBanking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
