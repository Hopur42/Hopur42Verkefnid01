using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkjatextaVerkefniHopur42.Startup))]
namespace SkjatextaVerkefniHopur42
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
