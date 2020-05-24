using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jess_Carr_Entertainment.Startup))]
namespace Jess_Carr_Entertainment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
