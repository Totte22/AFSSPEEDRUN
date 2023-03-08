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
    public class fuel_data1Controller : ApiController
    {
        private speedrunEntities3 db = new speedrunEntities3();

        // GET: api/fuel_data1
        public IQueryable<fuel_data1> Getfuel_data1()
        {
            return db.fuel_data1;
        }

        // GET: api/fuel_data1/5
        [ResponseType(typeof(fuel_data1))]
        public IHttpActionResult Getfuel_data1(int id)
        {
            fuel_data1 fuel_data1 = db.fuel_data1.Find(id);
            if (fuel_data1 == null)
            {
                return NotFound();
            }

            return Ok(fuel_data1);
        }

        // PUT: api/fuel_data1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putfuel_data1(int id, fuel_data1 fuel_data1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fuel_data1.id)
            {
                return BadRequest();
            }

            db.Entry(fuel_data1).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!fuel_data1Exists(id))
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

        // POST: api/fuel_data1
        [ResponseType(typeof(fuel_data1))]
        public IHttpActionResult Postfuel_data1(fuel_data1 fuel_data1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.fuel_data1.Add(fuel_data1);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (fuel_data1Exists(fuel_data1.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = fuel_data1.id }, fuel_data1);
        }

        // DELETE: api/fuel_data1/5
        [ResponseType(typeof(fuel_data1))]
        public IHttpActionResult Deletefuel_data1(int id)
        {
            fuel_data1 fuel_data1 = db.fuel_data1.Find(id);
            if (fuel_data1 == null)
            {
                return NotFound();
            }

            db.fuel_data1.Remove(fuel_data1);
            db.SaveChanges();

            return Ok(fuel_data1);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool fuel_data1Exists(int id)
        {
            return db.fuel_data1.Count(e => e.id == id) > 0;
        }
    }
}