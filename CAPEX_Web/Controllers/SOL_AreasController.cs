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
    public class SOL_AreasController : Controller
    {
        private CAPEXEntities db = new CAPEXEntities();

        // GET: SOL_Areas
        public ActionResult Index()
        {
            return View(db.SOL_Areas.ToList());
        }

        // GET: SOL_Areas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Areas sOL_Areas = db.SOL_Areas.Find(id);
            if (sOL_Areas == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Areas);
        }

        // GET: SOL_Areas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SOL_Areas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AREA_ID,AREA_NOMBRE,AREA_STATUS")] SOL_Areas sOL_Areas)
        {
            if (ModelState.IsValid)
            {
                db.SOL_Areas.Add(sOL_Areas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sOL_Areas);
        }

        // GET: SOL_Areas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Areas sOL_Areas = db.SOL_Areas.Find(id);
            if (sOL_Areas == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Areas);
        }

        // POST: SOL_Areas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AREA_ID,AREA_NOMBRE,AREA_STATUS")] SOL_Areas sOL_Areas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sOL_Areas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sOL_Areas);
        }

        // GET: SOL_Areas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Areas sOL_Areas = db.SOL_Areas.Find(id);
            if (sOL_Areas == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Areas);
        }

        // POST: SOL_Areas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SOL_Areas sOL_Areas = db.SOL_Areas.Find(id);
            db.SOL_Areas.Remove(sOL_Areas);
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
