using AmalCollections.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmalCollections.VMs
{
    public class ProductVM
    {
        public long Id { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool IsBestSelling { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsActive { get; set; }
        public string ImagePath { get; set; }
        public List<IFormFile> Images { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
