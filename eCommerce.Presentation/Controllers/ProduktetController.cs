using EdumindAkademia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json;

namespace EdumindAkademia.Controllers
{
    public class ProduktetController : Controller
    {
        private static DB _db;
        public ProduktetController(DB db)
        {
            _db = db;
        }

        // GET: ProduktetController
        public async Task<ActionResult> Index()
        {
            HttpClient client = new HttpClient();

            var response =  await client.GetAsync("https://localhost:7238/api/ProduktetAPI");
            if (response.IsSuccessStatusCode)
            {
                // Read the content as a string
                var jsonString = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON string to a C# object
                //var produktet = JsonSerializer.Deserialize<List<Produktet>>(jsonString);
                // Or if using Newtonsoft.Json
                var produktet = JsonConvert.DeserializeObject<List<ProduktetViewModel>>(jsonString);

                // Now you can work with the `produktet` object
                return View(produktet);
            }
            else
            {
                // Handle the error response
                throw new Exception($"Error: {response.StatusCode}");
            }
            
        }

        // GET: ProduktetController/Details/5
        public ActionResult Details(int id)
        {
            var produkti = _db.Produktet
                .Include(x => x.Kategoria)
                .Where(x => x.Numri.Equals(id)).SingleOrDefault();
            return View(produkti);
        }

        // GET: ProduktetController/Create
        public ActionResult Create()
        {
            var kategorite = _db.Kategorite.ToList();
            var kat_sel_list = new SelectList(kategorite, "Numri", "Titulli");
            ViewBag.kategorite = kat_sel_list;
            //int x = 3; ViewBag.x = x;
            return View();
        }

        // POST: ProduktetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produktet newProdukt)
        {
            //newProdukt.Kategoria.Titulli
            _db.Produktet.Add(newProdukt);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ProduktetController/Edit/5
        public ActionResult Edit(int id)
        {
            //LINQ
            var produktiNeModifikim = _db.Produktet.Find(id);

            var kategorite = _db.Kategorite.ToList();
            var kat_sel_list = new SelectList(kategorite, "Numri", "Titulli", produktiNeModifikim.KategoriaNumri);
            ViewBag.kategorite = kat_sel_list;
            //Produktet newProdukt = new Produktet();

            //foreach (var item in lista)
            //{
            //    if(item.Numri == id)
            //        newProdukt = item;
            //}

            return View(produktiNeModifikim);
        }

        // POST: ProduktetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Produktet produktiNewData)
        {
            try
            {
                var produktiExisting = _db.Produktet.Find(produktiNewData.Numri);
                if (produktiExisting != null)
                {
                    produktiExisting.Emri = produktiNewData.Emri;
                    produktiExisting.KategoriaNumri = produktiNewData.KategoriaNumri;
                    _db.SaveChanges();
                }
                else
                {
                    return View();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduktetController/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var produktiNeFshirje = _db.Produktet.Find(id);

            return View(produktiNeFshirje);
        }

        // POST: ProduktetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExecuteDelete(Produktet p)
        {
            try
            {
                var produktiNeFshirje = _db.Produktet.Find(p.Numri);
                if (produktiNeFshirje != null)
                {
                    _db.Produktet.Remove(produktiNeFshirje);
                    _db.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
