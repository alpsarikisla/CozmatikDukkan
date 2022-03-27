using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CozmatikDukkan.ViewModel
{
    public class DoPayViewModel
    {
       
        public string MerchandUserName { get; set; }
        public string MerchandPassword { get; set; }

        [Display(Name = "İsim Soyisim")]
        [Required(ErrorMessage = "isimSyisim Zorunludur")]
        [StringLength(maximumLength: 100, ErrorMessage = "1000 Karakter Olmalıdır")]
        public string NameSurname { get; set; }


        [Display(Name = "Kart Numarası")]
        [Required(ErrorMessage = "Kart numarası zorunludur")]
        [StringLength(maximumLength: 16, ErrorMessage = "16 Karakter Olmalıdır", MinimumLength =16)]
        public string CardNumber { get; set; }

        [Display(Name = "Son Kullanma Ay")]
        [Required(ErrorMessage = "Zorunludur")]
        [StringLength(maximumLength: 2, ErrorMessage = "16 Karakter Olmalıdır", MinimumLength = 2)]
        public string ReqMonth { get; set; }

        [Display(Name = "Son Kullanma Yıl")]
        [Required(ErrorMessage = "Zorunludur")]
        [StringLength(maximumLength: 4, ErrorMessage = "4 Karakter Olmalıdır", MinimumLength = 4)]
        public string ReqYear { get; set; }

        [Display(Name = "Güvenlik Kodu")]
        [Required(ErrorMessage = "Cvv zorunludur")]
        [StringLength(maximumLength: 3, ErrorMessage = "3 Karakter Olmalıdır", MinimumLength = 3)]
        public string Cvv { get; set; }

        [Display(Name = "Tutar")]
        public decimal Price { get; set; }
    }
}