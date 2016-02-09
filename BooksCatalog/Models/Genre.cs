using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BooksCatalog.Models
{
    [DataContract(IsReference = true)]
    public class Genre
    {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
 
        public Genre()
        {
            Books = new HashSet<Book>();    
        }
    }
}