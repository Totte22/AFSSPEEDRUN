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
    public class fuel_data4Controller : ApiController
    {
        private speedrunEntities3 db = new speedrunEntities3();

        // GET: api/fuel_data4
        public IQueryable<fuel_data4> Getfuel_data4()
        {
            return db.fuel_data4;
        }

        // GET: api/fuel_data4/5
        [ResponseType(typeof(fuel_data4))]
        public IHttpActionResult Getfuel_data4(int id)
        {
            fuel_data4 fuel_data4 = db.fuel_data4.Find(id);
            if (fuel_data4 == null)
            {
                return NotFound();
            }

            return Ok(fuel_data4);
        }

        // PUT: api/fuel_data4/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putfuel_data4(int id, fuel_data4 fuel_data4)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fuel_data4.id)
            {
                return BadRequest();
            }

            db.Entry(fuel_data4).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!fuel_data4Exists(id))
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

        // POST: api/fuel_data4
        [ResponseType(typeof(fuel_data4))]
        public IHttpActionResult Postfuel_data4(fuel_data4 fuel_data4)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.fuel_data4.Add(fuel_data4);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (fuel_data4Exists(fuel_data4.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = fuel_data4.id }, fuel_data4);
        }

        // DELETE: api/fuel_data4/5
        [ResponseType(typeof(fuel_data4))]
        public IHttpActionResult Deletefuel_data4(int id)
        {
            fuel_data4 fuel_data4 = db.fuel_data4.Find(id);
            if (fuel_data4 == null)
            {
                return NotFound();
            }

            db.fuel_data4.Remove(fuel_data4);
            db.SaveChanges();

            return Ok(fuel_data4);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool fuel_data4Exists(int id)
        {
            return db.fuel_data4.Count(e => e.id == id) > 0;
        }
    }
}