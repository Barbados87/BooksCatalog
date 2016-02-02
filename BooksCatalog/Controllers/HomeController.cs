using System.Web.Mvc;

namespace BooksCatalog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            return View();
        }
    }
}