using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using logistics.Models;

namespace logistics.Controllers
{
    public class importsController : Controller
    {
        private Model2 db = new Model2();

        // GET: imports
        public ActionResult Index()
        {
            return View(db.imports.ToList());
        }

        // GET: imports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            import import = db.imports.Find(id);
            if (import == null)
            {
                return HttpNotFound();
            }
            return View(import);
        }

        // GET: imports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: imports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,county,shoes_type,brand_name")] import import)
        {
            if (ModelState.IsValid)
            {
                db.imports.Add(import);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(import);
        }

        // GET: imports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            import import = db.imports.Find(id);
            if (import == null)
            {
                return HttpNotFound();
            }
            return View(import);
        }

        // POST: imports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,county,shoes_type,brand_name")] import import)
        {
            if (ModelState.IsValid)
            {
                db.Entry(import).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(import);
        }

        // GET: imports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            import import = db.imports.Find(id);
            if (import == null)
            {
                return HttpNotFound();
            }
            return View(import);
        }

        // POST: imports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            import import = db.imports.Find(id);
            db.imports.Remove(import);
            db.SaveChanges();
            return RedirectToAction("Index");
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
