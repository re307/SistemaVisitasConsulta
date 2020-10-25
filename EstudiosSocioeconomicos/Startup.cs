using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstudiosSocioeconomicos.Startup))]
namespace EstudiosSocioeconomicos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
