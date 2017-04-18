using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwitterClient.Startup))]
namespace TwitterClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
