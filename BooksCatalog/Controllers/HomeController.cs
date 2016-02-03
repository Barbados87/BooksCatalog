using System.Web.Mvc;
using BooksCatalog.DAL;

namespace BooksCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly CatalogContext _dbContext = new CatalogContext();

        public ActionResult Index()
        {
            return View(_dbContext.Books);
        }

        public ActionResult Details(int? id)
        {
            return View();
        }
    }
}