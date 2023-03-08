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
    public class fuel_data2Controller : ApiController
    {
        private speedrunEntities3 db = new speedrunEntities3();

        // GET: api/fuel_data2
        public IQueryable<fuel_data2> Getfuel_data2()
        {
            return db.fuel_data2;
        }

        // GET: api/fuel_data2/5
        [ResponseType(typeof(fuel_data2))]
        public IHttpActionResult Getfuel_data2(int id)
        {
            fuel_data2 fuel_data2 = db.fuel_data2.Find(id);
            if (fuel_data2 == null)
            {
                return NotFound();
            }

            return Ok(fuel_data2);
        }

        // PUT: api/fuel_data2/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putfuel_data2(int id, fuel_data2 fuel_data2)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fuel_data2.id)
            {
                return BadRequest();
            }

            db.Entry(fuel_data2).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!fuel_data2Exists(id))
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

        // POST: api/fuel_data2
        [ResponseType(typeof(fuel_data2))]
        public IHttpActionResult Postfuel_data2(fuel_data2 fuel_data2)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.fuel_data2.Add(fuel_data2);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (fuel_data2Exists(fuel_data2.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = fuel_data2.id }, fuel_data2);
        }

        // DELETE: api/fuel_data2/5
        [ResponseType(typeof(fuel_data2))]
        public IHttpActionResult Deletefuel_data2(int id)
        {
            fuel_data2 fuel_data2 = db.fuel_data2.Find(id);
            if (fuel_data2 == null)
            {
                return NotFound();
            }

            db.fuel_data2.Remove(fuel_data2);
            db.SaveChanges();

            return Ok(fuel_data2);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool fuel_data2Exists(int id)
        {
            return db.fuel_data2.Count(e => e.id == id) > 0;
        }
    }
}