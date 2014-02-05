using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IngvarJonassen.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tjenester()
        {
            return View();
        }


        public ActionResult Omoss()
        {
            return View();
        }

        public ActionResult Mur()
        {
            return View();
        }

      
        public ActionResult Inspirasjon()
        {
            return View();
        }
        public ActionResult Partnere()
        {
            return View();
        }
	}
}