using IoCContainer.Models;
using IoCContainer.Services;
using IoCContainer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IoCContainer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ILog _log;

        public HomeController(ILogger<HomeController> logger, ILog log)
        {
            _log = log;
            _logger = logger;
        }

        public string Index([FromServices] ILog log)
        {
            log.Info("index action içerisine bir istek gelmiştir");
            return "Service running";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
