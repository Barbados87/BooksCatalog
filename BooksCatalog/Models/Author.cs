using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BooksCatalog.Models
{
    [DataContract(IsReference = true)]
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
        public ICollection<Book> Books { get; set; }

        public Author()
        {
            Books = new HashSet<Book>();
        }
    }
}