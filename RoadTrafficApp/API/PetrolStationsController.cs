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
    public class PetrolStationsController : ApiController
    {
        private RoadContext db = new RoadContext();

        // GET: api/PetrolStations
        public IQueryable<PetrolStation> GetPetrolStations()
        {
            return db.PetrolStations;
        }

        // GET: api/PetrolStations/5
        [ResponseType(typeof(PetrolStation))]
        public async Task<IHttpActionResult> GetPetrolStation(int id)
        {
            PetrolStation petrolStation = await db.PetrolStations.FindAsync(id);
            if (petrolStation == null)
            {
                return NotFound();
            }

            return Ok(petrolStation);
        }

        // PUT: api/PetrolStations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPetrolStation(int id, PetrolStation petrolStation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != petrolStation.ID)
            {
                return BadRequest();
            }

            db.Entry(petrolStation).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetrolStationExists(id))
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

        // POST: api/PetrolStations
        [ResponseType(typeof(PetrolStation))]
        public async Task<IHttpActionResult> PostPetrolStation(PetrolStation petrolStation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PetrolStations.Add(petrolStation);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = petrolStation.ID }, petrolStation);
        }

        // DELETE: api/PetrolStations/5
        [ResponseType(typeof(PetrolStation))]
        public async Task<IHttpActionResult> DeletePetrolStation(int id)
        {
            PetrolStation petrolStation = await db.PetrolStations.FindAsync(id);
            if (petrolStation == null)
            {
                return NotFound();
            }

            db.PetrolStations.Remove(petrolStation);
            await db.SaveChangesAsync();

            return Ok(petrolStation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PetrolStationExists(int id)
        {
            return db.PetrolStations.Count(e => e.ID == id) > 0;
        }
    }
}