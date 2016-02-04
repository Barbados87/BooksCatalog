using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksCatalog.Models
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
 
        public Genre()
        {
            Books = new HashSet<Book>();    
        }
    }
}