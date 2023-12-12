using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmalCollections.Data
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int DocId { get; set; }
        public string DocType { get; set; }
        public DateTime Date { get; set; }
        public int? CustomerId { get; set; }
        public long ProductId { get; set; }
        public int Stock { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public double DiscountPercent { get; set; }
        public double NetAmount { get; set; }
        public string Status { get; set; }
        public string UserId { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
