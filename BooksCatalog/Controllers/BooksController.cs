﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BooksCatalog.DAL;
using BooksCatalog.Models;
using System.Data.Entity.Infrastructure;
using BooksCatalog.ViewModels;

namespace BooksCatalog.Controllers
{
    public class BooksController : ApiController
    {
        private CatalogContext _dbContext = new CatalogContext();

        [ResponseType(typeof(IEnumerable<BookModel>))]
        public async Task<IHttpActionResult> Get()
        {
            var books = await GetBooks();

            return Ok(books);
        }

        [ResponseType(typeof(Book))]
        public async Task<IHttpActionResult> Post(Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var isCorrect = await SaveAsync(book);

            return Ok(isCorrect);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._dbContext.Dispose();    
            }

            base.Dispose(disposing);
        }

        private async Task<bool> SaveAsync(Book book)
        {
            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        private async Task<IEnumerable<BookModel>> GetBooks()
        {
            var books = await _dbContext.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .ToListAsync();
            
            return books.Select(b => new BookModel(b));
        }
    }
}
