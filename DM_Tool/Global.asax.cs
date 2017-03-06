using System.Media;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DM_Tool
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            SoundPlayer bgMusic = new SoundPlayer();

            bgMusic.SoundLocation = Server.MapPath("music/08 Black Blade.wav");

            bgMusic.Play();
        }
    }
}
