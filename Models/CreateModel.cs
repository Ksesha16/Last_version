using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WEB.Context;
using WEB.Models;

namespace WEB.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        [BindProperty]
        public Products Product { get; set; }

        public CreateModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _dbContext.Product.Add(Product);
            _dbContext.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
