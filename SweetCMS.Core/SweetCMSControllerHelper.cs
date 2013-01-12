using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SweetCMS.Core
{
    public static class SweetCMSControllerHelper
    {
        public static IView RenderView(string path, ControllerContext context)
        {
            IView view = GetView(path, context);

            if (view == null)
            {
                throw new HttpException((int)HttpStatusCode.NotFound, string.Format("The page {0} was not found", path));
            }

            return view;
        }

        public static IView GetView(string path, ControllerContext context)
        {
            path = path ?? "Index";

            IView view = ResolveView(path, context);

            if(view != null)
                return view;

            if(path.ToLower().EndsWith("index"))
                return null;

            path = path + "/Index";
            return ResolveView(path, context);
        }

        private static IView ResolveView(string viewPath, ControllerContext context)
        {
            try
            {
                return ViewEngines.Engines.FindView(context, viewPath, null).View;
            }
            catch
            {
                return null;
            }
        }
    }
}