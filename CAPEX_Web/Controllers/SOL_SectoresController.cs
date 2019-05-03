using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CAPEX_Web;

namespace CAPEX_Web.Controllers
{
    public class SOL_SectoresController : Controller
    {
        private CAPEXEntities db = new CAPEXEntities();

        // GET: SOL_Sectores
        public ActionResult Index()
        {
            return View(db.SOL_Sectores.ToList());
        }

        // GET: SOL_Sectores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Sectores sOL_Sectores = db.SOL_Sectores.Find(id);
            if (sOL_Sectores == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Sectores);
        }

        // GET: SOL_Sectores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SOL_Sectores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SECTOR_ID,SECTOR_NOMBRE,AREA_ID,SECTOR_STATUS")] SOL_Sectores sOL_Sectores)
        {
            if (ModelState.IsValid)
            {
                db.SOL_Sectores.Add(sOL_Sectores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sOL_Sectores);
        }

        // GET: SOL_Sectores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Sectores sOL_Sectores = db.SOL_Sectores.Find(id);
            if (sOL_Sectores == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Sectores);
        }

        // POST: SOL_Sectores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SECTOR_ID,SECTOR_NOMBRE,AREA_ID,SECTOR_STATUS")] SOL_Sectores sOL_Sectores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sOL_Sectores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sOL_Sectores);
        }

        // GET: SOL_Sectores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Sectores sOL_Sectores = db.SOL_Sectores.Find(id);
            if (sOL_Sectores == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Sectores);
        }

        // POST: SOL_Sectores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SOL_Sectores sOL_Sectores = db.SOL_Sectores.Find(id);
            db.SOL_Sectores.Remove(sOL_Sectores);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
