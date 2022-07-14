using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Context;
using Proje_OOP.Entity;
using System.Linq;

namespace Proje_OOP.Controllers
{
    public class ProductController : Controller
    {
        private ProjectDb context = new();

        public IActionResult Index()
        {
            var values = context.Products.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            var product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}