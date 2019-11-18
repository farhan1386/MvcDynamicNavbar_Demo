using MvcDynamicNavbar_Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MvcDynamicNavbar_Demo.Controllers
{
    [RoutePrefix("HomeNavbar")]
    public class HomeNavbarController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        [ActionName("List")]
        [Route("List")]
        public ActionResult Index()
        {
            var navbar = db.Navbars.ToList();
            return View(navbar);
        }

        [Route("{id}")]
        public ActionResult Details(int id)
        {
            var navbar = db.Navbars.Find(id);
            return View(navbar);
        }

        [Route("New")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("New")]
        public ActionResult New(Navbar navbar)
        {
            if (ModelState.IsValid)
            {
                db.Navbars.Add(navbar);
                db.SaveChanges();
                return RedirectToAction("List", "HomeNavbar");
            }
            return View();
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var navbar = db.Navbars.Find(id);
            if (navbar == null)
            {
                return HttpNotFound();
            }
            return View(navbar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Edit/{id}")]
        public ActionResult Edit(Navbar navbar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(navbar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List", "HomeNavbar");
            }
            return View();
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var navbar = db.Navbars.Find(id);
            if (navbar == null)
            {
                return HttpNotFound();
            }
            return View(navbar);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("Delete/{id}")]
        public ActionResult ConfirmDelete(int id)
        {
            var navbar = db.Navbars.Find(id);
            db.Navbars.Remove(navbar);
            db.SaveChanges();
            return RedirectToAction("List", "HomeNavbar");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}