using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetUser()
        {
            User user = new User()
            {
                UserId = 1,
                FirstName = "Fırat",
                LastName = "Alçın"
            };
            return View();
        }

        [NonAction]
        public string GetFullName(User user)
        {
            return user.FirstName + " " + user.LastName;
        }
    }
}
