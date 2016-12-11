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
    public class TollsController : ApiController
    {
        private RoadContext db = new RoadContext();

        // GET: api/Tolls
        public IQueryable<TollDTO> GetTolls()
        {
            var tolls = from t in db.Tolls
                        select new TollDTO()
                        {
                            ID = t.ID,
                            Name = t.Name,
                            Location = t.Location,
                            Vehicles = t.Vehicles.Select(v => new VehicleDTO()
                            {
                                VehicleID = v.VehicleID,
                                TollID = v.TollID,
                                VehicleType = v.VehicleType,
                                Price = v.Price
                            }).ToList()
                        };
            return tolls;
        }

        // GET: api/Tolls/5
        [ResponseType(typeof(TollDTO))]
        public async Task<IHttpActionResult> GetToll(int id)
        {
            Toll t = await db.Tolls.FindAsync(id);
            if (t == null)
            {
                return NotFound();
            }

            TollDTO toll = new TollDTO
            {
                ID = t.ID,
                Name = t.Name,
                Location = t.Location,
                Vehicles = t.Vehicles.Select(v => new VehicleDTO()
                {
                    VehicleID = v.VehicleID,
                    TollID = v.TollID,
                    VehicleType = v.VehicleType,
                    Price = v.Price
                }).ToList()
            };

            return Ok(toll);
        }

        // PUT: api/Tolls/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutToll(int id, Toll toll)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != toll.ID)
            {
                return BadRequest();
            }

            db.Entry(toll).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TollExists(id))
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

        // POST: api/Tolls
        [ResponseType(typeof(Toll))]
        public async Task<IHttpActionResult> PostToll(Toll toll)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tolls.Add(toll);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = toll.ID }, toll);
        }

        // DELETE: api/Tolls/5
        [ResponseType(typeof(Toll))]
        public async Task<IHttpActionResult> DeleteToll(int id)
        {
            Toll toll = await db.Tolls.FindAsync(id);
            if (toll == null)
            {
                return NotFound();
            }

            db.Tolls.Remove(toll);
            await db.SaveChangesAsync();

            return Ok(toll);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TollExists(int id)
        {
            return db.Tolls.Count(e => e.ID == id) > 0;
        }
    }
}