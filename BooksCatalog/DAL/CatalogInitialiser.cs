using System.Collections.Generic;
using System.Data.Entity;
using BooksCatalog.Models;

namespace BooksCatalog.DAL
{
    public class CatalogInitialiser : DropCreateDatabaseIfModelChanges<CatalogContext>
    {
        protected override void Seed(CatalogContext context)
        {
            var authors = new List<Author>();
            var genres = new List<Genre>();
            var books = new List<Book>();

            context.SaveChanges();
        }
    }
}