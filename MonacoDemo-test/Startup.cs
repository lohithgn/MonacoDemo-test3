using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MonacoDemo_test.Startup))]
namespace MonacoDemo_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
