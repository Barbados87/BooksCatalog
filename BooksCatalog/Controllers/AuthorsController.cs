using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BooksCatalog.DAL;
using BooksCatalog.Models;

namespace BooksCatalog.Controllers
{
    public class AuthorsController : ApiController
    {
        private CatalogContext _dbContext = new CatalogContext();

        [ResponseType(typeof(List<Author>))]
        public async Task<IHttpActionResult> Get()
        {
            var books = await GetAuthors();

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

        private async Task<List<Author>> GetAuthors()
        {
            return await _dbContext.Authors.ToListAsync();
        }
    }
}
