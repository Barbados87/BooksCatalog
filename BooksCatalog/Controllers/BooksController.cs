using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BooksCatalog.DAL;
using BooksCatalog.Models;

namespace BooksCatalog.Controllers
{
    public class BooksController : ApiController
    {
        private CatalogContext _dbContext = new CatalogContext();

        [ResponseType(typeof(List<Book>))]
        public async Task<IHttpActionResult> Get()
        {
            var books = await GetBooks();

            return Ok(books);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._dbContext.Dispose();    
            }

            base.Dispose(disposing);
        }

        private async Task<List<Book>> GetBooks()
        {
            return await _dbContext.Books.Include(b => b.Author).Include(b => b.Genre).ToListAsync();
        }
    }
}
