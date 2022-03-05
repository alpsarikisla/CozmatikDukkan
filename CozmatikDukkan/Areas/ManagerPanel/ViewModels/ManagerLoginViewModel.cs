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
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "bu alan 3 ile 50 karakter arasında olmalıdır.", MinimumLength = 3)]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "bu alan 3 ile 50 karakter arasında olmalıdır.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}