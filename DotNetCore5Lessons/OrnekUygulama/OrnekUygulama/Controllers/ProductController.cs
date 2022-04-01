using Microsoft.AspNetCore.Mvc;

namespace OrnekUygulama.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            //Veri üretildi...
            return View(); // View fonksiyonu bu actiona ait view(cshtml) dosyasını tetikleyecek olan fonksiyondur.
        }
    }
}
