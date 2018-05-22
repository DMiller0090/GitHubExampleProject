using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubExampleProject.Startup))]
namespace GitHubExampleProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
