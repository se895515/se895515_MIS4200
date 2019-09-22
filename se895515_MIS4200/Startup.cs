using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(se895515_MIS4200.Startup))]
namespace se895515_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
