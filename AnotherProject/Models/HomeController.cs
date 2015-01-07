using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnotherProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "THe Home page";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FactoryViewer()
        {
            return View();
        }

        public ActionResult Game()
        {
            return View();
        }

        public ActionResult AddToWebsite()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }


    }
}
