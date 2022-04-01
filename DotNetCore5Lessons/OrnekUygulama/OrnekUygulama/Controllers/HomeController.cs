using Microsoft.AspNetCore.Mvc;

namespace OrnekUygulama.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //Controller'a gelen isteği karşılayan ve gerekli operasyonları gerçekleştiren metotlardır.
        {
            return View();
        }
    }
}
