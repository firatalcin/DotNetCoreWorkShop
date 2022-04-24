using AspNetCoreCS.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "fırat";
            ViewData["Name"] = "alçın";
            TempData["Name"] = "Fırat";

            Customer customer = new Customer() { Age = 24, FirstName = "Fırat", LastName = "Alçın"};
            return View(customer);
        }

        public IActionResult MyName()
        {
            return View();
        }
    }
}
