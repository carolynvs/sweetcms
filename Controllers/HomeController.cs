using System;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SweetCMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RenderView(string path)
        {
            IView view = GetView(path);

            if (view == null)
            {
                throw new HttpException((int)HttpStatusCode.NotFound, string.Format("The page {0} was not found", view));
            }

            return View(view);
        }

        public IView GetView(string path)
        {
            path = path ?? "Index";

            IView view = ResolveView(path);

            if (view != null)
                return view;

            if (path.ToLower().EndsWith("index"))
                return null;

            return ResolveView(path + "/Index");
        }

        private IView ResolveView(string viewPath)
        {
            try
            {
                return ViewEngines.Engines.FindView(ControllerContext, viewPath, null).View;
            }
            catch
            {
                return null;
            }
        }
    }
}
