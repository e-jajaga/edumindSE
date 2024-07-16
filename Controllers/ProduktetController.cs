using EdumindAkademia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EdumindAkademia.Controllers
{
    public class ProduktetController : Controller
    {
        private static DB db = new DB();

        // GET: ProduktetController
        public ActionResult Index()
        {   
            List<Produktet> produktet = db.Produktet.ToList();
            return View(produktet);
        }

        // GET: ProduktetController/Details/5
        public ActionResult Details(int id)
        {
            var produkti = db.Produktet
                .Include(x=>x.Kategoria)
                .Where(x=>x.Numri.Equals(id)).SingleOrDefault();
            return View(produkti);
        }

        // GET: ProduktetController/Create
        public ActionResult Create()
        {
            var kategorite = db.Kategorite.ToList();
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
            db.Produktet.Add(newProdukt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: ProduktetController/Edit/5
        public ActionResult Edit(int id)
        {
            //LINQ
            var produktiNeModifikim = db.Produktet.Find(id);

            var kategorite = db.Kategorite.ToList();
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
                var produktiExisting = db.Produktet.Find(produktiNewData.Numri);
                if (produktiExisting != null)
                {
                    produktiExisting.Emri = produktiNewData.Emri;
                    produktiExisting.KategoriaNumri = produktiNewData.KategoriaNumri;
                    db.SaveChanges();
                } else 
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
            var produktiNeFshirje = db.Produktet.Find(id);

            return View(produktiNeFshirje);
        }

        // POST: ProduktetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExecuteDelete(Produktet p)
        {
            try
            {
                var produktiNeFshirje = db.Produktet.Find(p.Numri);
                if (produktiNeFshirje != null)
                {
                    db.Produktet.Remove(produktiNeFshirje);
                    db.SaveChanges();
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
