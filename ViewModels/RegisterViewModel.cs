using System.ComponentModel.DataAnnotations;

namespace Lingva.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email уже занят")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Такое имя пользователя уже используется")]
        [Display(Name = "Имя пользователя")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Пароль не соответствует требованиям")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Пароли не совпадают")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}
