using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using steeltoetest.Models;
using steeltoetest.Options;

namespace steeltoetest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IOptionsSnapshot<SquidProxyServiceOption> _squidOptions;
        public HomeController(ILogger<HomeController> logger, IOptionsSnapshot<SquidProxyServiceOption> squidOptions)
        {
            _logger = logger;
            _squidOptions = squidOptions;
        }

        public IActionResult Index()
        {
            Console.WriteLine($"Retrieved these Squid Proxy Options: {JsonSerializer.Serialize(_squidOptions)}");
            return View();
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
