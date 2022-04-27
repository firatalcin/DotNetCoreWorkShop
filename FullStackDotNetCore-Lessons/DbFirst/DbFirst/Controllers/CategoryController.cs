using DbFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DbFirst.Controllers
{
    public class CategoryController : Controller
    {

        public IActionResult List()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                List<Category> categories = context.Categories.ToList();
                return View(categories);
            }
        }
    }
}
