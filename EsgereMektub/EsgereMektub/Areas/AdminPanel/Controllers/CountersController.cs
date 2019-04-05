using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EsgereMektub.Models;

namespace EsgereMektub.Areas.AdminPanel.Controllers
{
    public class CountersController : Controller
    {
        private esgeremektubEntities db = new esgeremektubEntities();

        // GET: AdminPanel/Counters
        public ActionResult Index()
        {
            return View(db.Counter.ToList());
        }

        // GET: AdminPanel/Counters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counter counter = db.Counter.Find(id);
            if (counter == null)
            {
                return HttpNotFound();
            }
            return View(counter);
        }

        // GET: AdminPanel/Counters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/Counters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Writted,Delivered")] Counter counter)
        {
            if (ModelState.IsValid)
            {
                db.Counter.Add(counter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(counter);
        }

        // GET: AdminPanel/Counters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counter counter = db.Counter.Find(id);
            if (counter == null)
            {
                return HttpNotFound();
            }
            return View(counter);
        }

        // POST: AdminPanel/Counters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Writted,Delivered")] Counter counter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(counter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(counter);
        }

        // GET: AdminPanel/Counters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Counter counter = db.Counter.Find(id);
            if (counter == null)
            {
                return HttpNotFound();
            }
            return View(counter);
        }

        // POST: AdminPanel/Counters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Counter counter = db.Counter.Find(id);
            db.Counter.Remove(counter);
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
