using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NitinGitWebsite.Startup))]
namespace NitinGitWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
