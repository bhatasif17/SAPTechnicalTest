using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAPTechnicalTest.Startup))]
namespace SAPTechnicalTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
