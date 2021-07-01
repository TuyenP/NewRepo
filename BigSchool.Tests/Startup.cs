using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool.Tests.Startup))]
namespace BigSchool.Tests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
