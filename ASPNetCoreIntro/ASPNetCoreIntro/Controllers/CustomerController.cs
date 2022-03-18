using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ASPNetCoreIntro.Models;
using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPNetCoreIntro.Services.Logging;

namespace ASPNetCoreIntro.Controllers
{
    [Route("deneme")]
    public class CustomerController : Controller
    {
        ILogger _logger;

      
        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }


        List<Customer> customers = new List<Customer>
            {
                new Customer{Id = 1, FirstName = "Fırat", LastName = "Alçın", City = "Ağrı" },
                new Customer{Id = 2, FirstName = "Engin", LastName = "Demirog", City = "Ankara"},
                new Customer{Id = 3, FirstName = "Enes", LastName = "Çiçek", City = "Sivas"}

            };

        List<string> shops = new List<string> { "İstanbul", "Ankara", "Ağrı" };

        [Route("index")]
        [Route("")]
        [Route("~/homepage")]

        public IActionResult Index()
        {
            _logger.Log("Veritabanına eklendi");
            var model = new CustomerListViewModel()
            {
                Customers = customers,
                Shops = shops
            };
            return View(model);
        }

        [HttpGet]
        [Route("save")]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel
            {
                Cities = new List<SelectListItem> 
                { 
                    new SelectListItem { Text = "Ankara", Value= "06"},
                    new SelectListItem { Text = "Ağrı", Value= "04"},
                    new SelectListItem { Text = "İstanbul", Value= "34"}
                },
            });
        }

        [HttpPost]
        [Route("save")]
        public IActionResult SaveCustomer(Customer customer)
        {
            customers.Add(customer);
            return RedirectToAction("Index");
        }
    }
}
