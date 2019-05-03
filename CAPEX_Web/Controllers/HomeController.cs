using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAPEX_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descripción de la Aplicación";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pagina de Contactos";

            return View();
        }

        public ActionResult Help()
        {
            ViewBag.Message = "Pagina de Ayuda";

            return View();
        }
    }
}