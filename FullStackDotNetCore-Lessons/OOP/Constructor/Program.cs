using Constructor.Models;
using System;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Kumanda";

            Product product2 = new Product("Kumanda");

            Console.WriteLine($"Ürün adı: {product2.ProductName} - oluşturma tarihi: {product2.CreatedDate}");
            

        }
    }
}
