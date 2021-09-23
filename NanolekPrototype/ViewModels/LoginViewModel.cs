using System.ComponentModel.DataAnnotations;

namespace NanolekPrototype.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email адрес")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}