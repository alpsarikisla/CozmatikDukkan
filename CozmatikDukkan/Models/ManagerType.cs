using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CozmatikDukkan.Models
{
    public class ManagerType
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Yönetici tür ismi yazılmalıdır")]
        [StringLength(maximumLength:20,ErrorMessage ="En fazla 20 karakter olmalıdır")]
        public string Name { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }
    }
}