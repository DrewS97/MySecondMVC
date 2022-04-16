using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySecondMVC.Models;

namespace MySecondMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Hello()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GreetMe(string name, string language)
        {
            Dictionary<string, string> helloDict = new Dictionary<string, string>
            {
                {"english", "Hello"},
                {"spanish", "Hola"},
                {"german", "Hallo"},
                {"french", "Salut"},
                {"portuguese", "Olá"}
            };
            ViewBag.Name = name;
            ViewBag.Hello = helloDict[language];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
