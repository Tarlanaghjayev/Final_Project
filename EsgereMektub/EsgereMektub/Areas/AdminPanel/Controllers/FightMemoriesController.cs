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
    public class FightMemoriesController : Controller
    {
        private esgeremektubEntities db = new esgeremektubEntities();

        // GET: AdminPanel/FightMemories
        public ActionResult Index()
        {
            return View(db.FightMemory.ToList());
        }

        // GET: AdminPanel/FightMemories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FightMemory fightMemory = db.FightMemory.Find(id);
            if (fightMemory == null)
            {
                return HttpNotFound();
            }
            return View(fightMemory);
        }

        // GET: AdminPanel/FightMemories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/FightMemories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Text,Image")] FightMemory fightMemory)
        {
            if (ModelState.IsValid)
            {
                db.FightMemory.Add(fightMemory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fightMemory);
        }

        // GET: AdminPanel/FightMemories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FightMemory fightMemory = db.FightMemory.Find(id);
            if (fightMemory == null)
            {
                return HttpNotFound();
            }
            return View(fightMemory);
        }

        // POST: AdminPanel/FightMemories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Text,Image")] FightMemory fightMemory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fightMemory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fightMemory);
        }

        // GET: AdminPanel/FightMemories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FightMemory fightMemory = db.FightMemory.Find(id);
            if (fightMemory == null)
            {
                return HttpNotFound();
            }
            return View(fightMemory);
        }

        // POST: AdminPanel/FightMemories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FightMemory fightMemory = db.FightMemory.Find(id);
            db.FightMemory.Remove(fightMemory);
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
