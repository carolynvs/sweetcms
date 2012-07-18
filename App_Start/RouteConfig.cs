using System.Web.Mvc;
using System.Web.Routing;

namespace SweetCMS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CMS",
                url: "{*path}",
                defaults: new {controller = "Home", action = "RenderView"}
                );
        }
    }
}