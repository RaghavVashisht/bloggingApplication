using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp4.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a very simple Blogging application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Raghav Vashisht";

            return View();
        }
    }
}