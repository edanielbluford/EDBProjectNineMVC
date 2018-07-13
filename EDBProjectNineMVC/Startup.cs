using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EDBProjectNineMVC.Startup))]
namespace EDBProjectNineMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
