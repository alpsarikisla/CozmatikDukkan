using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CozmatikDukkan.Areas.ManagerPanel.ViewModels
{
    public class ManagerLoginViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Mail adresi yazınız")]
        [StringLength(maximumLength: 50, ErrorMessage = "Mail 3 ile 50 karakter arasında olmalıdır.", MinimumLength = 3)]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre Yazınız")]
        [StringLength(maximumLength: 50, ErrorMessage = "Şifre 3 ile 50 karakter arasında olmalıdır.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}