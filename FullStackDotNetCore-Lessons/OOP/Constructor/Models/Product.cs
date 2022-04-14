using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public DateTime CreatedDate { get; set; }

        public Product()
        {
            CreatedDate = DateTime.Now; 
        }

        public Product(string productName) : this()
        {
            ProductName = productName;           
        }
    }
}
