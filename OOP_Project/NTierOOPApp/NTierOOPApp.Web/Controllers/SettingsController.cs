using Microsoft.AspNetCore.Mvc;

namespace NTierOOPApp.Web.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
