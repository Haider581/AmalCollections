using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmalCollections.Data
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public long ProductId { get; set; }
        [Required, StringLength(5000)]
        public string ImagePath { get; set; }
        public bool IsMain { get; set; }
    }
}
