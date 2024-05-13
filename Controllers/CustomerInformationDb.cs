using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_RazorLabbFour.Data;

namespace MVC_RazorLabbFour.Controllers
{
    public class CustomerInformationDb :Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerInformationDb(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customer = _context.Customers.ToList();
            return View(customer);
        }

        public async Task<IActionResult> AllBookLoan(int Id)
        {
            var books = await _context.BookLoans
                .Where(loan => loan.CustomerId == Id)
                .Select(loan => loan.Books)
                .ToListAsync();

            return View(books);
        }
    }
}
