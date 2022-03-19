using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CozmatikDukkan.Models
{
    public class Product
    {
        public int ID { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        public int BrandID { get; set; }

        [ForeignKey("BrandID")]
        public virtual Brand Brand { get; set; }

        [Display(Name="Isim")]
        [Required(ErrorMessage ="Ürün adı zorunludur")]
        [StringLength(maximumLength:100, ErrorMessage ="Ürün adı en fazla 100 karakter olmalıdır")]
        public string Name { get; set; }

        [Display(Name = "Ürün Özellikleri")]
        [Required(ErrorMessage = "Ürün adı zorunludur")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Ürün Fiyat")]
        public decimal Price { get; set; }

        [Display(Name = "Ürün Resim")]
        public string CoverImage { get; set; }

        [Display(Name = "Ürün Stok")]
        public int Stock { get; set; }

        [Display(Name = "Satış Durum")]
        public bool ProductStatus { get; set; }

        //public virtual ICollection<ProductImage> ProductImages { get; set; }

    }
}