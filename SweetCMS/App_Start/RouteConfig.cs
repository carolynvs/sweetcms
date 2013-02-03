using System.Web.Mvc;
using System.Web.Routing;
using SweetCMS.Core;

namespace SweetCMS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            SweetCMSRouteHelper.RegisterRoutes(routes, controller: "Dynamic");
        }
    }
}