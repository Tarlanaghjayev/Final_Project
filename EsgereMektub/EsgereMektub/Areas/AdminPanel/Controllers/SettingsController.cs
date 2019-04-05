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
    public class SettingsController : Controller
    {
        private esgeremektubEntities db = new esgeremektubEntities();

        // GET: AdminPanel/Settings
        public ActionResult Index()
        {
            return View(db.Setting.ToList());
        }

        // GET: AdminPanel/Settings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Setting setting = db.Setting.Find(id);
            if (setting == null)
            {
                return HttpNotFound();
            }
            return View(setting);
        }

        // GET: AdminPanel/Settings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/Settings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MainLogo,AktLogo,Fb,Twitter,Insta,Youtube,Location,Phone,Mail")] Setting setting)
        {
            if (ModelState.IsValid)
            {
                db.Setting.Add(setting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(setting);
        }

        // GET: AdminPanel/Settings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Setting setting = db.Setting.Find(id);
            if (setting == null)
            {
                return HttpNotFound();
            }
            return View(setting);
        }

        // POST: AdminPanel/Settings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MainLogo,AktLogo,Fb,Twitter,Insta,Youtube,Location,Phone,Mail")] Setting setting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(setting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(setting);
        }

        // GET: AdminPanel/Settings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Setting setting = db.Setting.Find(id);
            if (setting == null)
            {
                return HttpNotFound();
            }
            return View(setting);
        }

        // POST: AdminPanel/Settings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Setting setting = db.Setting.Find(id);
            db.Setting.Remove(setting);
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
