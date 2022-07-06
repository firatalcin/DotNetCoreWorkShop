using System;
using System.Collections.Generic;

namespace AutoMapperApp.API.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public string Province { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}