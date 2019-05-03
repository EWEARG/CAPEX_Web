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
    public class SOL_ProyectosController : Controller
    {
        private CAPEXEntities db = new CAPEXEntities();

        // GET: SOL_Proyectos
        public ActionResult Index()
        {
            var sOL_Proyectos = db.SOL_Proyectos.Include(s => s.SOL_Areas).Include(s => s.SOL_Organizaciones).Include(s => s.SOL_Sectores);
            return View(sOL_Proyectos.ToList());
        }

        // GET: SOL_Proyectos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Proyectos sOL_Proyectos = db.SOL_Proyectos.Find(id);
            if (sOL_Proyectos == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Proyectos);
        }

        // GET: SOL_Proyectos/Create
        public ActionResult Create()
        {
            ViewBag.AREA_ID = new SelectList(db.SOL_Areas, "AREA_ID", "AREA_NOMBRE");
            ViewBag.ORGANIZACION_ID = new SelectList(db.SOL_Organizaciones, "ORGANIZACION_ID", "ORGANIZACION_NOMBRE");
            ViewBag.SECTOR_ID = new SelectList(db.SOL_Sectores, "SECTOR_ID", "SECTOR_NOMBRE");
            return View();
        }

        // POST: SOL_Proyectos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Proyecto,PROJECT_NUMBER,PROYECTO_NOMBRE,NOMBRE_LARGO,DESCRIPCION,ESTADO_ID,PROYECTO_STATUS,AREA_ID,AREA_NOMBRE,SECTOR_ID,SECTOR_NOMBRE,ORGANIZACION_ID,ORGANIZACION_NOMBRE,PROYECTO_TYPE,PROYECTO_TYPE_DESCRIPTION,PROYECTO_DIVISA,MONTO_DIVISA,MONTO_CONVERTIDO,MONTO_PRESUPUESTADO,DISTRIBUTION_RULE,DISTRIBUTION_RULE_MEANING,CONTEXT_VALUE,PROYECTO_CON_PRESUPUESTO,FECHA_INICIO_ESTIMADO,FECHA_INICIO_REAL,DURACION_ESTIMADA_MESES,INGRESO_DATE,ESTIMADO_DATE,PRESUPUESTADO_DATE,COMPLETADO_DATE,ACTUALIZADO_DATE,ACTUALIZADO_POR,CREADO_DATE,CREADO_POR")] SOL_Proyectos sOL_Proyectos)
        {
            if (ModelState.IsValid)
            {
                db.SOL_Proyectos.Add(sOL_Proyectos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AREA_ID = new SelectList(db.SOL_Areas, "AREA_ID", "AREA_NOMBRE", sOL_Proyectos.AREA_ID);
            ViewBag.ORGANIZACION_ID = new SelectList(db.SOL_Organizaciones, "ORGANIZACION_ID", "ORGANIZACION_NOMBRE", sOL_Proyectos.ORGANIZACION_ID);
            ViewBag.SECTOR_ID = new SelectList(db.SOL_Sectores, "SECTOR_ID", "SECTOR_NOMBRE", sOL_Proyectos.SECTOR_ID);
            return View(sOL_Proyectos);
        }

        // GET: SOL_Proyectos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Proyectos sOL_Proyectos = db.SOL_Proyectos.Find(id);
            if (sOL_Proyectos == null)
            {
                return HttpNotFound();
            }
            ViewBag.AREA_ID = new SelectList(db.SOL_Areas, "AREA_ID", "AREA_NOMBRE", sOL_Proyectos.AREA_ID);
            ViewBag.ORGANIZACION_ID = new SelectList(db.SOL_Organizaciones, "ORGANIZACION_ID", "ORGANIZACION_NOMBRE", sOL_Proyectos.ORGANIZACION_ID);
            ViewBag.SECTOR_ID = new SelectList(db.SOL_Sectores, "SECTOR_ID", "SECTOR_NOMBRE", sOL_Proyectos.SECTOR_ID);
            return View(sOL_Proyectos);
        }

        // POST: SOL_Proyectos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Proyecto,PROJECT_NUMBER,PROYECTO_NOMBRE,NOMBRE_LARGO,DESCRIPCION,ESTADO_ID,PROYECTO_STATUS,AREA_ID,AREA_NOMBRE,SECTOR_ID,SECTOR_NOMBRE,ORGANIZACION_ID,ORGANIZACION_NOMBRE,PROYECTO_TYPE,PROYECTO_TYPE_DESCRIPTION,PROYECTO_DIVISA,MONTO_DIVISA,MONTO_CONVERTIDO,MONTO_PRESUPUESTADO,DISTRIBUTION_RULE,DISTRIBUTION_RULE_MEANING,CONTEXT_VALUE,PROYECTO_CON_PRESUPUESTO,FECHA_INICIO_ESTIMADO,FECHA_INICIO_REAL,DURACION_ESTIMADA_MESES,INGRESO_DATE,ESTIMADO_DATE,PRESUPUESTADO_DATE,COMPLETADO_DATE,ACTUALIZADO_DATE,ACTUALIZADO_POR,CREADO_DATE,CREADO_POR")] SOL_Proyectos sOL_Proyectos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sOL_Proyectos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AREA_ID = new SelectList(db.SOL_Areas, "AREA_ID", "AREA_NOMBRE", sOL_Proyectos.AREA_ID);
            ViewBag.ORGANIZACION_ID = new SelectList(db.SOL_Organizaciones, "ORGANIZACION_ID", "ORGANIZACION_NOMBRE", sOL_Proyectos.ORGANIZACION_ID);
            ViewBag.SECTOR_ID = new SelectList(db.SOL_Sectores, "SECTOR_ID", "SECTOR_NOMBRE", sOL_Proyectos.SECTOR_ID);
            return View(sOL_Proyectos);
        }

        // GET: SOL_Proyectos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOL_Proyectos sOL_Proyectos = db.SOL_Proyectos.Find(id);
            if (sOL_Proyectos == null)
            {
                return HttpNotFound();
            }
            return View(sOL_Proyectos);
        }

        // POST: SOL_Proyectos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SOL_Proyectos sOL_Proyectos = db.SOL_Proyectos.Find(id);
            db.SOL_Proyectos.Remove(sOL_Proyectos);
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
