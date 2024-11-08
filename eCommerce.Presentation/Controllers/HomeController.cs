using EdumindAkademia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Configuration;

namespace EdumindAkademia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static DB _db;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, DB db, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _db = db;   //dependency injection design pattern
        }

        public IActionResult Index()
        {
            var produktet = _db.Produktet.Take(9).ToList();
            return View(produktet);
        }

        // GET: ProduktetController/Details/5
        public ActionResult ProductDetails(int id)
        {
            var produkti = _db.Produktet
                .Include(x => x.Kategoria)
                .Where(x => x.Numri.Equals(id)).SingleOrDefault();
            return View(produkti);
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

        public IActionResult GetKomentet(int NumriProduktit)
        {
            //partial view
            var komentet = _db.Komentet.Where(x=> x.NumriProduktit == NumriProduktit && x.Eaprovuar == true).ToList();
            return PartialView("_ListComments", komentet);
        }

        
    }
}
