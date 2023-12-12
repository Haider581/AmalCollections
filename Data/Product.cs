using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmalCollections.Data
{
    public class Product
    {
        public long Id { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool IsBestSelling { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsActive { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
