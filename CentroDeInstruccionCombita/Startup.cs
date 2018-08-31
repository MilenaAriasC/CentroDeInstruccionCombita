using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentroDeInstruccionCombita.Startup))]
namespace CentroDeInstruccionCombita
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
