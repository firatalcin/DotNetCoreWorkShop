using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UseViewBag()
        {
            ViewBag.UserName = "Fırat";

            User user = new User();
            user.FirstName = "Fırat";
            user.LastName = "Alçın";
            ViewBag.FullName = user;

            List<User> users = new List<User>()
            {
                new User() { FirstName = "Fırat", LastName = "Alçın"},
                new User() { FirstName = "Enes", LastName = "Çiçek"},
                new User(){ FirstName = "Cemal", LastName= "Kun"}
            };
            ViewBag.UserListed = users;
            return View();
        }

        public IActionResult UseViewData()
        {
            ViewData["UserName"] = "Fırat";

            User user = new User();
            user.FirstName = "Fırat";
            user.LastName = "Alçın";
            ViewData["User"] = user;
            return View();
        }

        public IActionResult UseTempData()
        {
            TempData["name"] = "Fırat";
            return RedirectToAction("UseTempDataTest");
        }

        public IActionResult UseTempDataTest()
        {
            string userName = TempData["name"].ToString();
            return View();
        }
    }
}
