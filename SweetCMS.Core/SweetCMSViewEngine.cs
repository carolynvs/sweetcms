using System.Web.Mvc;

namespace SweetCMS.Core
{
    public class SweetCMSViewEngine : RazorViewEngine
    {
        private readonly string _viewsPath;

        public SweetCMSViewEngine(string viewsPath)
        {
            _viewsPath = viewsPath + "/{0}.cshtml";
            ViewLocationFormats = PartialViewLocationFormats = new[] { _viewsPath };
        }

        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            return base.FindView(controllerContext, viewName, masterName, useCache);
        }
    }
}