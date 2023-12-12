using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmalCollections.Data
{
    public class Cart
    {
        public int Id { get; set; }
        public long ProductId { get; set; }
        public int Qty { get; set; }
        [StringLength(450)]
        public string Cookie { get; set; }
        public DateTime Expiry { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }

    }
}
