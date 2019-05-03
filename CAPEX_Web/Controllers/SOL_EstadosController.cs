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
    public class SOL_EstadosController : Controller
    {
        private CAPEXEntities db = new CAPEXEntities();

        // GET: SOL_Estados
        public ActionResult Index()
        {
            return View(db.SOL_Estados.ToList());
        }

        // GET: SOL_Estados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Estados sOL_Estados = db.SOL_Estados.Find(id);
            if (sOL_Estados == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Estados);
        }

        // GET: SOL_Estados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SOL_Estados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ESTADO_ID,ESTADO_MODULO,PROYECTO_STATUS,ESTADO_PROXIMO")] SOL_Estados sOL_Estados)
        {
            if (ModelState.IsValid)
            {
                db.SOL_Estados.Add(sOL_Estados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sOL_Estados);
        }

        // GET: SOL_Estados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Estados sOL_Estados = db.SOL_Estados.Find(id);
            if (sOL_Estados == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Estados);
        }

        // POST: SOL_Estados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ESTADO_ID,ESTADO_MODULO,PROYECTO_STATUS,ESTADO_PROXIMO")] SOL_Estados sOL_Estados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sOL_Estados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sOL_Estados);
        }

        // GET: SOL_Estados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Estados sOL_Estados = db.SOL_Estados.Find(id);
            if (sOL_Estados == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Estados);
        }

        // POST: SOL_Estados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SOL_Estados sOL_Estados = db.SOL_Estados.Find(id);
            db.SOL_Estados.Remove(sOL_Estados);
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
