using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BooksCatalog.Models;

namespace BooksCatalog.ViewModels
{

    public class BookModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string AuthorName
        {
            get { return Author.FullName; }
        }

        public string GenreName
        {
            get { return Genre.Name; }
        }

        public AuthorModel Author { get; set; }
        
        public GenreModel Genre { get; set; }

        public BookModel(Book book)
        {
            Id = book.Id;
            Name = book.Name;
            Author = new AuthorModel(book.Author);
            Genre = new GenreModel(book.Genre);
        }

        public BookModel()
        {
            
        }
    }
}