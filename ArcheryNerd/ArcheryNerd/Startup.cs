using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArcheryNerd.Startup))]
namespace ArcheryNerd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
