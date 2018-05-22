using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula2205_Entidy.Startup))]
namespace Aula2205_Entidy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
