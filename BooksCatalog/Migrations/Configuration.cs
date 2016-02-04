using BooksCatalog.Models;
using System.Data.Entity.Migrations;

namespace BooksCatalog.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BooksCatalog.DAL.CatalogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.CatalogContext context)
        {
            context.Genres.AddOrUpdate(
                g => g.Name,
                new Genre { Id = 1, Name = "Fantazy" },
                new Genre { Id = 2, Name = "Adventure" },
                new Genre { Id = 3, Name = "Love story" }
            );
            context.SaveChanges();

            context.Authors.AddOrUpdate(
                a => a.Id,
                new Author { Id = 1, FirstName = "Mark", LastName = "Twen" }
            );
            context.SaveChanges();

            context.Books.AddOrUpdate(
                b => b.Name,
                new Book { Name = "Tom Saywer", AuthorId = 1, GenreId = 2 }
            );
            context.SaveChanges();
        }
    }
}
