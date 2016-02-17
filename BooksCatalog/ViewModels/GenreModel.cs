using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BooksCatalog.Models;

namespace BooksCatalog.ViewModels
{
    public class GenreModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public GenreModel(Genre genre)
        {
            Id = genre.Id;
            Name = genre.Name;
        }

        public GenreModel()
        {
            
        }
    }
}