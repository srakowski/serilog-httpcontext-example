using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LoggingExample.Controllers
{
    public class HomeController : Controller
    {
        ILogger<HomeController> _log;

        public HomeController(ILogger<HomeController> log)
        {
            this._log = log;
        }

        public IActionResult Index()
        {
            _log.LogInformation("Index called");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
