using CIS3285_Unit3Sample_2024.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CIS3285_Unit3Sample_2024.Controllers
{
    public class HomeController : Controller
    {
        // Tom added this comment
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
