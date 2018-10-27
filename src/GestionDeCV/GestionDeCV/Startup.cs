using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(GestionDeCV.Startup))]
namespace GestionDeCV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}