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
    public class LettersController : Controller
    {
        private esgeremektubEntities db = new esgeremektubEntities();

        // GET: AdminPanel/Letters
        public ActionResult Index()
        {
            return View(db.Letters.ToList());
        }

        // GET: AdminPanel/Letters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Letters letters = db.Letters.Find(id);
            if (letters == null)
            {
                return HttpNotFound();
            }
            return View(letters);
        }

        // GET: AdminPanel/Letters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/Letters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Text,Status")] Letters letters)
        {
            if (ModelState.IsValid)
            {
                db.Letters.Add(letters);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(letters);
        }

        // GET: AdminPanel/Letters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Letters letters = db.Letters.Find(id);
            if (letters == null)
            {
                return HttpNotFound();
            }
            return View(letters);
        }

        // POST: AdminPanel/Letters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Text,Status")] Letters letters)
        {
            if (ModelState.IsValid)
            {
                db.Entry(letters).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(letters);
        }

        // GET: AdminPanel/Letters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Letters letters = db.Letters.Find(id);
            if (letters == null)
            {
                return HttpNotFound();
            }
            return View(letters);
        }

        // POST: AdminPanel/Letters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Letters letters = db.Letters.Find(id);
            db.Letters.Remove(letters);
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
