using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WEB.Context
{
    public class User : IdentityUser
    {
        [Key]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }


    }
}
