using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArabaSatisOtomasyon.Startup))]
namespace ArabaSatisOtomasyon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
