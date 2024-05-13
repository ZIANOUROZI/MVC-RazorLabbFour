using System.ComponentModel.DataAnnotations;

namespace MVC_RazorLabbFour.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(50, MinimumLength =16)]
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public List<BookLoan> BookLoans { get; set; }
    }
}
