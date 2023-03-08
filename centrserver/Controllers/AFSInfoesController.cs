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
using System.Web.UI.WebControls;
using Antlr.Runtime;
using centrserver;
using Newtonsoft.Json;

namespace centrserver.Controllers
{
    public class AFSInfoesController : ApiController
    {
        private speedrunEntities3 db = new speedrunEntities3();

        private class GetFuelInfo
        {
            public string address { get; set; }
            public string type1 { get; set; }
            public decimal price1 { get; set; }
            public int amount1 { get; set; }
            public string type2 { get; set; }
            public decimal price2 { get; set; }
            public int amount2 { get; set; }
            public string type3 { get; set; }
            public decimal price3 { get; set; }
            public int amount3 { get; set; }
            public string type4 { get; set; }
            public decimal price4 { get; set; }
            public int amount4 { get; set; }
        }

            

        [Route("api/fuelINFO/")]
        public IHttpActionResult GetfuelINFO(int id)
        {
            AFSInfo afsinfo = db.AFSInfo.Find(id);
            if (afsinfo == null)
                return NotFound();
            GetFuelInfo temp = new GetFuelInfo();
            temp.address = afsinfo.Address;

            fuel_data1 f1 = db.fuel_data1.Find(id);
            temp.type1 = f1.fuel_Type;
            temp.price1 = f1.fuel_Price;
            temp.amount1 = f1.fuel_Amount;
            fuel_data2 f2 = db.fuel_data2.Find(id);
            temp.type2 = f2.fuel_Type;
            temp.price2 = f2.fuel_Price;
            temp.amount2 = f2.fuel_Amount;
            fuel_data3 f3 = db.fuel_data3.Find(id);
            temp.type3 = f3.fuel_Type;
            temp.price3 = f3.fuel_Price;
            temp.amount3 = f3.fuel_Amount;
            fuel_data4 f4 = db.fuel_data4.Find(id);
            temp.type4 = f4.fuel_Type;
            temp.price4 = f4.fuel_Price;
            temp.amount4 = f4.fuel_Amount;
            return Ok(temp);
        }

        // GET: api/AFSInfoes
        public IQueryable<AFSInfo> GetAFSInfo()
        {
            return db.AFSInfo;
        }

        // GET: api/AFSInfoes/5
        [ResponseType(typeof(AFSInfo))]
        public IHttpActionResult GetAFSInfo(int id)
        {
            AFSInfo aFSInfo = db.AFSInfo.Find(id);
            if (aFSInfo == null)
            {
                return NotFound();
            }

            return Ok(aFSInfo);
        }

        // PUT: api/AFSInfoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAFSInfo(int id, AFSInfo aFSInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aFSInfo.Id)
            {
                return BadRequest();
            }

            db.Entry(aFSInfo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AFSInfoExists(id))
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

        // POST: api/AFSInfoes
        [ResponseType(typeof(AFSInfo))]
        public IHttpActionResult PostAFSInfo(AFSInfo aFSInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AFSInfo.Add(aFSInfo);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AFSInfoExists(aFSInfo.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = aFSInfo.Id }, aFSInfo);
        }

        // DELETE: api/AFSInfoes/5
        [ResponseType(typeof(AFSInfo))]
        public IHttpActionResult DeleteAFSInfo(int id)
        {
            AFSInfo aFSInfo = db.AFSInfo.Find(id);
            if (aFSInfo == null)
            {
                return NotFound();
            }

            db.AFSInfo.Remove(aFSInfo);
            db.SaveChanges();

            return Ok(aFSInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AFSInfoExists(int id)
        {
            return db.AFSInfo.Count(e => e.Id == id) > 0;
        }
    }
}