using Microsoft.Owin;
using Owin;
using System.Media;

[assembly: OwinStartupAttribute(typeof(DM_Tool.Startup))]
namespace DM_Tool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            
        }
    }
}
