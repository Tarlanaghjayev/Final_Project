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
    public class FMtextsController : Controller
    {
        private esgeremektubEntities db = new esgeremektubEntities();

        // GET: AdminPanel/FMtexts
        public ActionResult Index()
        {
            return View(db.FMtext.ToList());
        }

        // GET: AdminPanel/FMtexts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FMtext fMtext = db.FMtext.Find(id);
            if (fMtext == null)
            {
                return HttpNotFound();
            }
            return View(fMtext);
        }

        // GET: AdminPanel/FMtexts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/FMtexts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Text")] FMtext fMtext)
        {
            if (ModelState.IsValid)
            {
                db.FMtext.Add(fMtext);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fMtext);
        }

        // GET: AdminPanel/FMtexts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FMtext fMtext = db.FMtext.Find(id);
            if (fMtext == null)
            {
                return HttpNotFound();
            }
            return View(fMtext);
        }

        // POST: AdminPanel/FMtexts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Text")] FMtext fMtext)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fMtext).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fMtext);
        }

        // GET: AdminPanel/FMtexts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FMtext fMtext = db.FMtext.Find(id);
            if (fMtext == null)
            {
                return HttpNotFound();
            }
            return View(fMtext);
        }

        // POST: AdminPanel/FMtexts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FMtext fMtext = db.FMtext.Find(id);
            db.FMtext.Remove(fMtext);
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
