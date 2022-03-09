using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(studentmanagementsystem.Startup))]
namespace studentmanagementsystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
