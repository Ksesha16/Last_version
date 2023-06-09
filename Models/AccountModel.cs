using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using WEB.Context;

namespace WEB.Pages
{
    public class AccountModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public AccountModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User User { get; set; }

        [BindProperty]
        public IFormFile PhotoFile { get; set; }

        public IActionResult OnGet()
        {
            // Получить имя текущего аутентифицированного пользователя
            var userName = HttpContext.User.Identity.Name;

            // Получить текущего пользователя из базы данных
            User = _dbContext.Users.FirstOrDefault(u => u.Login == userName);

            if (User == null)
            {
                return NotFound();
            }

            return Page();
        }

       
    }
}
