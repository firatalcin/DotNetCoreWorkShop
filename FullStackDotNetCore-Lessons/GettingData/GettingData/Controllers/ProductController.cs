using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product(){ProductId = 1, ProductName = "Televizyon" , CategoryName = "Teknoloji"},
            new Product(){ProductId = 2, ProductName = "Telefon", CategoryName = "Teknoloji"},
            new Product() {ProductId = 3, ProductName = "Tabak", CategoryName = "Mutfak"}
        };

        public IActionResult GetAllProducts()
        {
            return View(products);
        }

        public IActionResult GetProductById(int id)
        {
            var product = products.Find(x => x.ProductId == id);
            if(product == null)
            {
                ViewBag.Error = "Verilen Id'de bir ürün bulunamadı";
            }
            return View(product);
        }

        public IActionResult GetProductByCategoryName(string categoryName)
        {
            var productList = products.FindAll(x => x.CategoryName == categoryName);
            return View(productList);

        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            products.Add(product);
            return View("GetAllProducts", products);
        }
    }
}
