using BlogApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp4.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [AllowAnonymous]
        public ActionResult Index()
        {
            var postsList = db.Posts.ToList();
            postsList.Reverse();
            return View("../Posts/index", postsList);
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Welcome to FreeSpace community!";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Raghav Vashisht";

            return View();
        }
    }
}