using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string productName = "Fırat Alçın";
            return View(productName as Object);
        }

        public IActionResult UrunGoster()
        {
            Product product = new Product();
            product.ProductName = "Televizyon";
            product.UnitPrice = 5000;
            return View(product);
        }

        public IActionResult GetProductList()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { ProductName = "Telefon", CategoryName = "Teknoloji", UnitPrice = 3500});
            products.Add(new Product() { ProductName = "Elma", CategoryName = "Meyve", UnitPrice = 3});
            products.Add(new Product() { ProductName = "Televizyon", CategoryName = "Teknoloji", UnitPrice = 5000});

            return View(products);
        }
    }
}
