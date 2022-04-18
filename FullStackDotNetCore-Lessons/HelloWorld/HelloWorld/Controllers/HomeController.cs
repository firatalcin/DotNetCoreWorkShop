using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller //controller
    {
        public string Index() //action
        {
            return "Uygulama çalışıyor";
        }

        public string Test()
        {
            return "bu test action'udur";
        }

        public IActionResult Selamla()
        {
            return View();
        }

        public IActionResult Selamla2()
        {
            return View("Test2");
        }
    }
}
