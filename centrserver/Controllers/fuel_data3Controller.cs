using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using centrserver;

namespace centrserver.Controllers
{
    public class fuel_data3Controller : ApiController
    {
        private speedrunEntities3 db = new speedrunEntities3();

        // GET: api/fuel_data3
        public IQueryable<fuel_data3> Getfuel_data3()
        {
            return db.fuel_data3;
        }

        // GET: api/fuel_data3/5
        [ResponseType(typeof(fuel_data3))]
        public IHttpActionResult Getfuel_data3(int id)
        {
            fuel_data3 fuel_data3 = db.fuel_data3.Find(id);
            if (fuel_data3 == null)
            {
                return NotFound();
            }

            return Ok(fuel_data3);
        }

        // PUT: api/fuel_data3/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putfuel_data3(int id, fuel_data3 fuel_data3)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fuel_data3.id)
            {
                return BadRequest();
            }

            db.Entry(fuel_data3).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!fuel_data3Exists(id))
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

        // POST: api/fuel_data3
        [ResponseType(typeof(fuel_data3))]
        public IHttpActionResult Postfuel_data3(fuel_data3 fuel_data3)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.fuel_data3.Add(fuel_data3);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (fuel_data3Exists(fuel_data3.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = fuel_data3.id }, fuel_data3);
        }

        // DELETE: api/fuel_data3/5
        [ResponseType(typeof(fuel_data3))]
        public IHttpActionResult Deletefuel_data3(int id)
        {
            fuel_data3 fuel_data3 = db.fuel_data3.Find(id);
            if (fuel_data3 == null)
            {
                return NotFound();
            }

            db.fuel_data3.Remove(fuel_data3);
            db.SaveChanges();

            return Ok(fuel_data3);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool fuel_data3Exists(int id)
        {
            return db.fuel_data3.Count(e => e.id == id) > 0;
        }
    }
}