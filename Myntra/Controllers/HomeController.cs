using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myntra.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //dev branch

            //Change 1 in dev branch
            //Change 2 in dev branch
            //Change 3 in dev branch
            //Change 4 in dev branch
            //Change 5 in dev branch
            //Change 6 in dev branch
            //Change 7 in dev branch
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
    }
}