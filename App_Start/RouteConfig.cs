using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace SweetCMS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapRoute(
            name: "Dynamic",
            url: "{view}",
            constraints: new { view = GetAvailableViews() },
            defaults: new { controller = "Home", action = "RenderPage" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        private static string GetAvailableViews()
        {
            string viewsFolder = HttpContext.Current.Server.MapPath("~/Views/Home");
            IEnumerable<string> views = Directory.EnumerateFiles(viewsFolder).Select(Path.GetFileNameWithoutExtension);
            return string.Join("|", views);
        }
    }
}