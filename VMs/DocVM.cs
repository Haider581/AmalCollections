using AmalCollections.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmalCollections.VMs
{
    public class DocVM
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int DocId { get; set; }
        public string DocType { get; set; }
        public DateTime Date { get; set; }
        public int? CustomerId { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public Product Product { get; set; }
        public string ImagePath { get; set; }
        public int Stock { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public double DiscountPercent { get; set; }
        public double NetAmount { get; set; }
        public string Status { get; set; }
        public string UserId { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }

    }
}
