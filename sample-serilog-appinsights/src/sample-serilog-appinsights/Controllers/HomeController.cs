using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppInsightsSample.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            // Log an event
            //var properties = new Dictionary<string, string>() { { "Hero", "Spiderman" } };
            //var measurements = new Dictionary<string, string> { { "CurrentTimestamp", DateTime.Now.ToString() } };

            _logger.LogWarning("Hero : {Hero}, Current TimeStamp : {CurrentTimeStamp}", "Spiderman", DateTime.Now.ToString());

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
