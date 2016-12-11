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
    public class VehiclesController : ApiController
    {
        private RoadContext db = new RoadContext();

        // GET: api/Vehicles
        public IQueryable<VehicleDTO> GetVechicles()
        {
            var vehicles = from v in db.Vechicles
                           select new VehicleDTO()
                           {
                               VehicleID = v.VehicleID,
                               TollID = v.TollID,
                               VehicleType = v.VehicleType,
                               Price = v.Price,
                               Tolls = v.Tolls.Select(t => new TollDTO()
                               {
                                   ID = t.ID,
                                   Name = t.Name,
                                   Location = t.Location
                               }).ToList()
                           };
            return vehicles;
        } 

        // GET: api/Vehicles/5
        [ResponseType(typeof(VehicleDTO))]
        public async Task<IHttpActionResult> GetVehicle(int id)
        {
            Vehicle v = await db.Vechicles.FindAsync(id);
            if (v == null)
            {
                return NotFound();
            }

            VehicleDTO vehicle = new VehicleDTO
            {
                VehicleID = v.VehicleID,
                TollID = v.TollID,
                VehicleType = v.VehicleType,
                Price = v.Price,
                Tolls = v.Tolls.Select(t => new TollDTO()
                {
                    ID = t.ID,
                    Name = t.Name,
                    Location = t.Location
                }).ToList()
            };

            return Ok(vehicle);
        }

        // PUT: api/Vehicles/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vehicle.VehicleID)
            {
                return BadRequest();
            }

            db.Entry(vehicle).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleExists(id))
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

        // POST: api/Vehicles
        [ResponseType(typeof(Vehicle))]
        public async Task<IHttpActionResult> PostVehicle(Vehicle vehicle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vechicles.Add(vehicle);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = vehicle.VehicleID }, vehicle);
        }

        // DELETE: api/Vehicles/5
        [ResponseType(typeof(Vehicle))]
        public async Task<IHttpActionResult> DeleteVehicle(int id)
        {
            Vehicle vehicle = await db.Vechicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            db.Vechicles.Remove(vehicle);
            await db.SaveChangesAsync();

            return Ok(vehicle);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VehicleExists(int id)
        {
            return db.Vechicles.Count(e => e.VehicleID == id) > 0;
        }
    }
}