using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAPEX_Web.Controllers
{
    public class REPORT_Controller : Controller
    {
        // GET: REPORT_
        public ActionResult Index()
        {
            return View();
        }

        // GET: REPORT_/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: REPORT_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: REPORT_/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: REPORT_/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: REPORT_/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: REPORT_/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: REPORT_/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
