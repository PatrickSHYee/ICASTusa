using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICASTusa.Startup))]
namespace ICASTusa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
