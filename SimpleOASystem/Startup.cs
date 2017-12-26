using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleOASystem.Startup))]
namespace SimpleOASystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
