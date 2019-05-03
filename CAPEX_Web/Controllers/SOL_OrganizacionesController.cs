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
    public class SOL_OrganizacionesController : Controller
    {
        private CAPEXEntities db = new CAPEXEntities();

        // GET: SOL_Organizaciones
        public ActionResult Index()
        {
            return View(db.SOL_Organizaciones.ToList());
        }

        // GET: SOL_Organizaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Organizaciones sOL_Organizaciones = db.SOL_Organizaciones.Find(id);
            if (sOL_Organizaciones == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Organizaciones);
        }

        // GET: SOL_Organizaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SOL_Organizaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ORGANIZACION_ID,ORGANIZACION_NOMBRE,ORGANIZACION_STATUS")] SOL_Organizaciones sOL_Organizaciones)
        {
            if (ModelState.IsValid)
            {
                db.SOL_Organizaciones.Add(sOL_Organizaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sOL_Organizaciones);
        }

        // GET: SOL_Organizaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Organizaciones sOL_Organizaciones = db.SOL_Organizaciones.Find(id);
            if (sOL_Organizaciones == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Organizaciones);
        }

        // POST: SOL_Organizaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ORGANIZACION_ID,ORGANIZACION_NOMBRE,ORGANIZACION_STATUS")] SOL_Organizaciones sOL_Organizaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sOL_Organizaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sOL_Organizaciones);
        }

        // GET: SOL_Organizaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Organizaciones sOL_Organizaciones = db.SOL_Organizaciones.Find(id);
            if (sOL_Organizaciones == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Organizaciones);
        }

        // POST: SOL_Organizaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SOL_Organizaciones sOL_Organizaciones = db.SOL_Organizaciones.Find(id);
            db.SOL_Organizaciones.Remove(sOL_Organizaciones);
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
