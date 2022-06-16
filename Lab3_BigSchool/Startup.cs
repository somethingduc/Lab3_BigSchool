using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_BigSchool.Startup))]
namespace Lab3_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
