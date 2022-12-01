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
    public class exportsController : Controller
    {
        private Model2 db = new Model2();

        // GET: exports
        public ActionResult Index()
        {
            return View(db.exports.ToList());
        }

        // GET: exports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            export export = db.exports.Find(id);
            if (export == null)
            {
                return HttpNotFound();
            }
            return View(export);
        }

        // GET: exports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: exports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,shoes_type,brand_name,export_address")] export export)
        {
            if (ModelState.IsValid)
            {
                db.exports.Add(export);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(export);
        }

        // GET: exports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            export export = db.exports.Find(id);
            if (export == null)
            {
                return HttpNotFound();
            }
            return View(export);
        }

        // POST: exports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,shoes_type,brand_name,export_address")] export export)
        {
            if (ModelState.IsValid)
            {
                db.Entry(export).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(export);
        }

        // GET: exports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            export export = db.exports.Find(id);
            if (export == null)
            {
                return HttpNotFound();
            }
            return View(export);
        }

        // POST: exports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            export export = db.exports.Find(id);
            db.exports.Remove(export);
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
