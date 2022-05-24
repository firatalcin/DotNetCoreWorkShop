using System;
using System.Collections.Generic;

namespace EfWebApp.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public DateTime CreatedTime { get; set; }

        public ProductDetail ProductDetail { get; set; }

        public ICollection<SaleHistory> SaleHistories { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
