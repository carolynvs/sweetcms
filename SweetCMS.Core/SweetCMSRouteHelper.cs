using System.Web.Mvc;
using System.Web.Routing;

namespace SweetCMS.Core
{
    public static class SweetCMSRouteHelper
    {
        public static void RegisterRoutes(RouteCollection routes, string controller = "SweetCMS", string action = "RenderView")
        {
            routes.MapRoute(
                name: "SweetCMS Dynamic Views",
                url: "{*path}",
                defaults: new { controller, action}
                );
        }
    }
}