using MvcDynamicNavbar_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDynamicNavbar_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult NavigationBar()
        {
            var navigation = db.Navbars.ToList();
            return PartialView("_Navbar",navigation);
        }

        public ActionResult Skills()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Journey()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Blogs()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}