using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jess_Carr_Entertainment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Just a little JCE.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Streams()
        {
            ViewBag.Message = "THe streams";

            return View();
        }

        public ActionResult Music()
        {
            ViewBag.Message = "Smooth Stuff";

            return View();
        }

        public ActionResult Podcasts()
        {
            ViewBag.Message = "Good Listens";

            return View();
        }

        public ActionResult Art()
        {
            ViewBag.Message = "artbyian";

            return View();
        }

        public ActionResult Team()
        {
            ViewBag.Message = "The Team";

            return View();
        }
    }
}