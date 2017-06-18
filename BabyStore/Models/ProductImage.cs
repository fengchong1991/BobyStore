using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BabyStore.Models
{
    public class ProductImage
    {
        public int ID { get; set; }

        [StringLength(100)]
        [Display(Name="File")]
        [Index(IsUnique =true)]
        public string FileName { get; set; }
        public virtual ICollection<ProductImageMapping> ProductImageMappings { get; set; }

    }
}