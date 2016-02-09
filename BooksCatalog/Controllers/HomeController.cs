using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using BooksCatalog.DAL;
using BooksCatalog.Models;

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
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Book book = _dbContext.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }
    }
}