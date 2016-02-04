using System.Data.Entity;
using System.Web.Mvc;
using BooksCatalog.DAL;

namespace BooksCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly CatalogContext _dbContext = new CatalogContext();

        public ActionResult Index()
        {
            return View(_dbContext.Books.Include(b => b.Author).Include(b => b.Genre));
        }

        public ActionResult Details(int? id)
        {
            return View();
        }
    }
}