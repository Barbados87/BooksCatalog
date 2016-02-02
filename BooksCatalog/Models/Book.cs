using System.ComponentModel.DataAnnotations.Schema;

namespace BooksCatalog.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
    }
}