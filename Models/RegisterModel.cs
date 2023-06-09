using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB.Context;

namespace WEB.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public RegisterModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public User User { get; set; }

        public bool RegistrationSuccessful { get; set; }

        public void OnGet()
        {
            // Выполнить действия при получении страницы регистрации
        }
        public string ErrorMessage { get; set; }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                ErrorMessage = "Некорректные данные регистрации";
                return Page();
            }

            // Добавить нового пользователя в базу данных
            _dbContext.Users.Add(User);
            _dbContext.SaveChanges();

            RegistrationSuccessful = true;

            return Page();
        }
    }
}