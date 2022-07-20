using Microsoft.AspNetCore.Mvc;

namespace NTierOOPApp.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
