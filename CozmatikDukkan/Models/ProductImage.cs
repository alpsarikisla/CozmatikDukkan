using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CozmatikDukkan.Models
{
    public class ProductImage
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [StringLength(maximumLength:50, ErrorMessage ="Resim Yolu en fazla 50 karakter olmalıdır")]
        public string ImagePath { get; set; }
    }
}