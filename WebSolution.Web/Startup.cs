using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSolution.Web.Startup))]
namespace WebSolution.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
