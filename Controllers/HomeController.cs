using EdumindAkademia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EdumindAkademia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static DB _db;

        public HomeController(ILogger<HomeController> logger, DB db)
        {
            _logger = logger;
            _db = db;   //dependency injection design pattern
        }

        public IActionResult Index()
        {
            var produktetFundit = _db.Produktet.Take(9).ToList();
            return View(produktetFundit);
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
