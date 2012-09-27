using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Getting Ready for Git Workshop! (Edited from GitHub) Branch 1";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
