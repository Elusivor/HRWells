using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRWells.Startup))]
namespace HRWells
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
