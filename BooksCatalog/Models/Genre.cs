using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BooksCatalog.Models
{
    public class Genre
    {
        public int Id { get; set; }
   
        public string Name { get; set; }
        
        //public virtual ICollection<Book> Books { get; set; }
    }
}