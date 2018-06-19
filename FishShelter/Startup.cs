using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FishShelter.Startup))]
namespace FishShelter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
