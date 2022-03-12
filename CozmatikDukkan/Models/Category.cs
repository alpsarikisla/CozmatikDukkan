using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CozmatikDukkan.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name="Kategori Adı")]
        [Required(ErrorMessage ="Kategori adı zorunludur")]
        [StringLength(maximumLength:50,ErrorMessage ="En Fazla 50 karakter olmalıdır")]
        public string Name { get; set; }

        [Display(Name = "Kategori Açıklama")]
        [StringLength(maximumLength: 500, ErrorMessage = "En Fazla 500 karakter olmalıdır")]
        public string Description { get; set; }
    }
}