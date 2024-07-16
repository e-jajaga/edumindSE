using EdumindAkademia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EdumindAkademia.Controllers
{
    public class KategoriteController : Controller
    {
        private static DB db = new DB();
        // GET: KategoriteController
        public ActionResult Index()
        {
            List<Kategorite> lista = new List<Kategorite>();
            lista = db.Kategorite.ToList();
            return View(lista);
        }

        // GET: KategoriteController/Details/5
        public ActionResult Details(int id)
        {
            var kat = db.Kategorite.Find(id);
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
                db.Kategorite.Add(kategoria);
                db.SaveChanges();
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
            var katNeNdryshim = db.Kategorite.Find(id);
            return View(katNeNdryshim);
        }

        // POST: KategoriteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Kategorite katNeNdryshim)
        {
            try
            {
                var katOrigjinale = db.Kategorite.Find(katNeNdryshim.Numri);
                katOrigjinale.Titulli = katNeNdryshim.Titulli;
                db.SaveChanges();

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
            var katNeFshirje = db.Kategorite.Find(id);
            return View(katNeFshirje);
        }

        // POST: KategoriteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var katNeFshirje = db.Kategorite.Find(id);
                db.Kategorite.Remove(katNeFshirje);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
