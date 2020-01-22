using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nm916616MIS4200.Startup))]
namespace nm916616MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
