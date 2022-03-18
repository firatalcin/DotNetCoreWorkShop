using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreIntro.Controllers
{
    public class SessionDemoController : Controller
    {
        
        public string Index1()
        {
            Customer customer = new Customer { Id = 1, FirstName = "Betül", LastName = "Avcı", City = "Manisa" };

            HttpContext.Session.SetString("isim", "Engin");
            HttpContext.Session.SetObject("musteri", customer);
            return "Session Oluştu";
        }

        public string Index2()
        {
            var customer = HttpContext.Session.GetObject<Customer>("musteri");
            return customer.FirstName;
        }
    }
}
