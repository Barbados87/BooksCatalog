using System.ComponentModel.DataAnnotations.Schema;

namespace BooksCatalog.Models
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}