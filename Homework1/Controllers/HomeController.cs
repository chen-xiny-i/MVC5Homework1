using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string test)
        {
            return View();
        }

        public ActionResult About(string test)
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(string test)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}