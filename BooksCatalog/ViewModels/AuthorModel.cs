using BooksCatalog.Models;

namespace BooksCatalog.ViewModels
{
    public class AuthorModel
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        public AuthorModel(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
        }

        public AuthorModel()
        {
            
        }
    }
}