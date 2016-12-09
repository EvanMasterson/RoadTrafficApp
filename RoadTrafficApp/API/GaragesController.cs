using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using RoadTrafficApp.Models;

namespace RoadTrafficApp.API
{
    public class GaragesController : ApiController
    {
        private RoadContext db = new RoadContext();

        // GET: api/Garages
        public IQueryable<Garage> GetGarages()
        {
            return db.Garages;
        }

        // GET: api/Garages/5
        [ResponseType(typeof(Garage))]
        public async Task<IHttpActionResult> GetGarage(int id)
        {
            Garage garage = await db.Garages.FindAsync(id);
            if (garage == null)
            {
                return NotFound();
            }

            return Ok(garage);
        }

        // PUT: api/Garages/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGarage(int id, Garage garage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != garage.ID)
            {
                return BadRequest();
            }

            db.Entry(garage).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GarageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Garages
        [ResponseType(typeof(Garage))]
        public async Task<IHttpActionResult> PostGarage(Garage garage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Garages.Add(garage);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = garage.ID }, garage);
        }

        // DELETE: api/Garages/5
        [ResponseType(typeof(Garage))]
        public async Task<IHttpActionResult> DeleteGarage(int id)
        {
            Garage garage = await db.Garages.FindAsync(id);
            if (garage == null)
            {
                return NotFound();
            }

            db.Garages.Remove(garage);
            await db.SaveChangesAsync();

            return Ok(garage);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GarageExists(int id)
        {
            return db.Garages.Count(e => e.ID == id) > 0;
        }
    }
}