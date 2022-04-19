using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using PassingData.Models.ViewModel;
using System;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer(){FirstName = "Fırat", LastName = "Alçın"},
            new Customer(){FirstName = "Enes",LastName = "Çiçek"},
            new Customer() {FirstName ="Cemil",LastName = "Kun"}
        };

        public IActionResult UseViewModel()
        {
            Product product = new Product();
            product.ProductName = "Monitör";
            product.CategoryName = "Elektronik";
            product.UnitPrice = 1;

            string date = DateTime.Now.ToString();

            CustomerAndProductVM customerAndProductVM = new CustomerAndProductVM()
            {
                Customers = customers,
                product = product,
                Date = date
            };

            return View(customerAndProductVM);
        }

        public IActionResult UseTuple()
        {
            Product product = new Product();
            product.ProductName = "Telefon";
            product.CategoryName = "Elektronik";
            product.UnitPrice = 4;

            string date = DateTime.Now.ToString();

            (List<Customer>,Product,string) customerAndProduct = (customers, product, date);

            return View(customerAndProduct);
        }
    }
}
