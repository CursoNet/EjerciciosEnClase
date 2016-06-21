using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjercicioGitHub.Startup))]
namespace EjercicioGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
