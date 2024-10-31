using EdumindAkademia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;
using EdumindAkademia.ViewModels;
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
            var url = _configuration["WeatherForecastAPI"] + "/WeatherForecast";
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(url);
            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string resultJsonString = response.Content.ReadAsStringAsync().Result;
                List<WeatherForecastVM> result = JsonConvert.DeserializeObject<List<WeatherForecastVM>>(resultJsonString);
                return PartialView("_WeatherForecast", result);
            }

            return null;
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

        #region WeatherForecast
        public IActionResult GetWeatherForecast()
        {
            var url = _configuration["WeatherForecastAPI"] + "/WeatherForecast";
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(url);
            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string resultJsonString = response.Content.ReadAsStringAsync().Result;
                List<WeatherForecastVM> result = JsonConvert.DeserializeObject<List<WeatherForecastVM>>(resultJsonString);
                return PartialView("_WeatherForecast", result);
            }

            return null;
        }

        #endregion
    }
}
