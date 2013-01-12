using System.Web.Mvc;

namespace SweetCMS.Core
{
    public class SweetCMSController : Controller
    {
        [OutputCache(Duration = int.MaxValue)]
        public virtual ActionResult RenderView(string path)
        {
            IView view = SweetCMSControllerHelper.RenderView(path, ControllerContext);

            return View(view);
        }
    }
}
