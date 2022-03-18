using ASPNetCoreIntro.Entities;
using System.Collections.Generic;

namespace ASPNetCoreIntro.Models
{
    public class CustomerListViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<string> Shops { get; set; }
    }
}
