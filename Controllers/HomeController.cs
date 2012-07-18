using System.Web.Mvc;

namespace SweetCMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RenderPage(string view)
        {
            return View(view);
        }
    }
}
