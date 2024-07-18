using EdumindAkademia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EdumindAkademia.Controllers
{
    public class KategoriteController : Controller
    {
        private static DB _db;

        public KategoriteController(DB db)
        {
            _db = db;
        }
        // GET: KategoriteController
        public ActionResult Index()
        {
            List<Kategorite> lista = new List<Kategorite>();
            lista = _db.Kategorite.ToList();
            return View(lista);
        }

        // GET: KategoriteController/Details/5
        public ActionResult Details(int id)
        {
            var kat = _db.Kategorite.Find(id);
            return View(kat);
        }

        // GET: KategoriteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KategoriteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Kategorite kategoria)
        {
            try
            {
                _db.Kategorite.Add(kategoria);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KategoriteController/Edit/5
        public ActionResult Edit(int id)
        {
            var katNeNdryshim = _db.Kategorite.Find(id);
            return View(katNeNdryshim);
        }

        // POST: KategoriteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Kategorite katNeNdryshim)
        {
            try
            {
                var katOrigjinale = _db.Kategorite.Find(katNeNdryshim.Numri);
                katOrigjinale.Titulli = katNeNdryshim.Titulli;
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KategoriteController/Delete/5
        public ActionResult Delete(int id)
        {
            var katNeFshirje = _db.Kategorite.Find(id);
            return View(katNeFshirje);
        }

        // POST: KategoriteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var katNeFshirje = _db.Kategorite.Find(id);
                _db.Kategorite.Remove(katNeFshirje);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
