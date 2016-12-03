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
    public class PetrolStationsController : Controller
    {
        private RoadContext db = new RoadContext();

        // GET: PetrolStations
        public ActionResult Index()
        {
            return View(db.PetrolStations.ToList());
        }

        // GET: PetrolStations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetrolStation petrolStation = db.PetrolStations.Find(id);
            if (petrolStation == null)
            {
                return HttpNotFound();
            }
            return View(petrolStation);
        }

        // GET: PetrolStations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetrolStations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Location,Petrol,Diesel")] PetrolStation petrolStation)
        {
            if (ModelState.IsValid)
            {
                db.PetrolStations.Add(petrolStation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(petrolStation);
        }

        // GET: PetrolStations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetrolStation petrolStation = db.PetrolStations.Find(id);
            if (petrolStation == null)
            {
                return HttpNotFound();
            }
            return View(petrolStation);
        }

        // POST: PetrolStations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Location,Petrol,Diesel")] PetrolStation petrolStation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(petrolStation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(petrolStation);
        }

        // GET: PetrolStations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetrolStation petrolStation = db.PetrolStations.Find(id);
            if (petrolStation == null)
            {
                return HttpNotFound();
            }
            return View(petrolStation);
        }

        // POST: PetrolStations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PetrolStation petrolStation = db.PetrolStations.Find(id);
            db.PetrolStations.Remove(petrolStation);
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
