using System.ComponentModel.DataAnnotations;

namespace MVC_RazorLabbFour.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public bool IsReturned { get; set; }
        public List<BookLoan> BookLoans { get; set; }
    }
}
