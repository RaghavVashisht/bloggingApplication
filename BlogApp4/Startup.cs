using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogApp4.Startup))]
namespace BlogApp4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
