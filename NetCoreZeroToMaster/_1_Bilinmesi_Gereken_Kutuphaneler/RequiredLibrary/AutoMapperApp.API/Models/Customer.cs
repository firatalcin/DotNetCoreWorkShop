using System;
using System.Collections.Generic;

namespace AutoMapperApp.API.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Age { get; set; }
        public DateTime? BirthDay { get; set; }

        public CreditCard CreditCard { get; set; }

        public string GetFullName()
        {
            return $"{Name}-{Email}-{Age}";
        }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}