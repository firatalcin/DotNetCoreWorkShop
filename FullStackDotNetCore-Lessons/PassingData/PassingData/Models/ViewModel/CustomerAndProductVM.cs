using System.Collections.Generic;

namespace PassingData.Models.ViewModel
{
    public class CustomerAndProductVM
    {
        public List<Customer> Customers { get; set; }
        public Product product { get; set; }
        public string Date { get; set; }
    }
}
