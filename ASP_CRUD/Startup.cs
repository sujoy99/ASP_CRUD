using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_CRUD.Startup))]
namespace ASP_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
