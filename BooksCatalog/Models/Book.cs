using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksCatalog.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
    }
}