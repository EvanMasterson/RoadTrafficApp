using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RoadTrafficApp.Models;

namespace RoadTrafficApp.Controllers
{
    public class TollsController : Controller
    {
        private RoadContext db = new RoadContext();

        // GET: Tolls
        public ActionResult Index()
        {
            return View(db.Tolls.ToList());
        }

        // GET: Tolls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Toll toll = db.Tolls.Find(id);
            if (toll == null)
            {
                return HttpNotFound();
            }
            return View(toll);
        }

        // GET: Tolls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tolls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Location")] Toll toll)
        {
            if (ModelState.IsValid)
            {
                db.Tolls.Add(toll);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(toll);
        }

        // GET: Tolls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Toll toll = db.Tolls.Find(id);
            if (toll == null)
            {
                return HttpNotFound();
            }
            return View(toll);
        }

        // POST: Tolls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Location")] Toll toll)
        {
            if (ModelState.IsValid)
            {
                db.Entry(toll).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(toll);
        }

        // GET: Tolls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Toll toll = db.Tolls.Find(id);
            if (toll == null)
            {
                return HttpNotFound();
            }
            return View(toll);
        }

        // POST: Tolls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Toll toll = db.Tolls.Find(id);
            db.Tolls.Remove(toll);
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
