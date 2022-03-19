using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CozmatikDukkan.Models
{
    public class Brand
    {
        public int ID { get; set; }

        [Display(Name = "Marka Adı")]
        [Required(ErrorMessage = "Marka adı zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "En Fazla 50 karakter olmalıdır")]
        public string Name { get; set; }

        [Display(Name = "Yayın Durum")]
        public bool BrandStatus { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}