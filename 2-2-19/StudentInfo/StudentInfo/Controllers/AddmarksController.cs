using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentInfo.Models;

namespace StudentInfo.Controllers
{
    public class AddmarksController : Controller
    {
        private UserContext db = new UserContext();

        //
        // GET: /Addmarks/

        public ActionResult Index()
        {
            var studinfos = db.StudInfos.Include(s => s.Department);
            return View(studinfos.ToList());
        }

        //
        // GET: /Addmarks/Details/5

        public ActionResult Details(int id = 0)
        {
            StudInfo studinfo = db.StudInfos.Find(id);
            if (studinfo == null)
            {
                return HttpNotFound();
            }
            return View(studinfo);
        }

        //
        // GET: /Addmarks/Create

        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "depname");
            return View();
        }

        //
        // POST: /Addmarks/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudInfo studinfo)
        {
            if (ModelState.IsValid)
            {
                db.StudInfos.Add(studinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "depname", studinfo.DepartmentId);
            return View(studinfo);
        }

        //
        // GET: /Addmarks/Edit/5

        public ActionResult Edit(int id = 0)
        {
            StudInfo studinfo = db.StudInfos.Find(id);
            if (studinfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "depname", studinfo.DepartmentId);
            return View(studinfo);
        }

        //
        // POST: /Addmarks/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudInfo studinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "depname", studinfo.DepartmentId);
            return View(studinfo);
        }

        //
        // GET: /Addmarks/Delete/5

        public ActionResult Delete(int id = 0)
        {
            StudInfo studinfo = db.StudInfos.Find(id);
            if (studinfo == null)
            {
                return HttpNotFound();
            }
            return View(studinfo);
        }

        //
        // POST: /Addmarks/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudInfo studinfo = db.StudInfos.Find(id);
            db.StudInfos.Remove(studinfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}