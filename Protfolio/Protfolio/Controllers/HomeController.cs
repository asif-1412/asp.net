using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Protfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Personal()
        {
            ViewBag.Message = "Your personal page.";

            return View();
        }
        public ActionResult Education()
        {
            ViewBag.Message = "Educational Qualifications.";
            
            return View();
        }
        public ActionResult Projects()
        {
            ViewBag.Message = "Projects that are done.";
            
            return View();
        }
        public ActionResult References()
        {
            ViewBag.Message = "People that I have worked with.";
            
            return View();
        }
    }
}