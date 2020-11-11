using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1.Controllers
{
    public class OffersController : Controller
    {
        // GET: Offers
        public ActionResult Index()
        {
            ViewBag.Nombre = "Este es mi ViewBag";
            return View();
        }
    }
}