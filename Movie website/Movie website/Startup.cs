using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movie_website.Startup))]
namespace Movie_website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
