using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using BooksCatalog.Models;

namespace BooksCatalog.DAL
{
    public class CatalogInitialiser : DropCreateDatabaseIfModelChanges<CatalogContext>
    {
        protected override void Seed(CatalogContext context)
        {
            context.Authors.AddOrUpdate(a => a.LastName, new Author { FirstName = "Jack", LastName = "London" });
            context.Authors.AddOrUpdate(a => a.LastName, new Author { FirstName = "Mark", LastName = "Twain" });
            context.SaveChanges();

            context.Genres.AddOrUpdate(g => g.Name, new Genre { Name = "Fantazy" });
            context.Genres.AddOrUpdate(g => g.Name, new Genre { Name = "Poem" });
            context.Genres.AddOrUpdate(g => g.Name, new Genre { Name = "Story" });
            context.SaveChanges();
        }
    }
}