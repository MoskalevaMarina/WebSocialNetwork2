using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSocialNetwork2.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Логин(Email)")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name ="Запомнить?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }

    }
}
