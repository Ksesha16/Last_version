using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB.Context;

namespace WEB.Pages
{
    public class AuthModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public AuthModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public string Login { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Login == Login && u.Password == Password);
            if (user != null)
            {
                // Авторизация успешна, выполнить перенаправление на главную страницу
                return RedirectToPage("/Index");
            }

            // Авторизация неудачна, вернуться на страницу авторизации
            return Page();
        }
    }
}
