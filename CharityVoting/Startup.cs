using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CharityVoting.Startup))]
namespace CharityVoting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
