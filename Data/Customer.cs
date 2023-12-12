using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmalCollections.Data
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(500)]
        public string Email { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        [StringLength(10)]
        public string PostalCode { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }

        public virtual User User { get; set; }       

    }
}
