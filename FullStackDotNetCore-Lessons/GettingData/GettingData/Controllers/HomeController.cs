using Microsoft.AspNetCore.Mvc;

namespace GettingData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            return View();
        }

        // Home/UseQueryString?name=firat&surname=Alcin
        public string UseQueryString(string name, string surName)
        {
            return "Uygulama Çalışıyor";
        }
    }
}
