using System.ComponentModel.DataAnnotations;

namespace MVC_RazorLabbFour.Models
{
    public class BookLoan
    {
        [Key]
        public int BookLoanId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public int BookId { get; set; }
        public Book Books { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
