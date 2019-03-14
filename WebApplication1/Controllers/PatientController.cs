using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PatientController : ApiController
    {
        // POST api/values

        [HttpPost]
        [Route("api/patients")]
        public void Post([FromBody]Patient patient)
        {

            patient.insert();
        }


        //[HttpGet]
        //[Route("api/orders")]
        //public IEnumerable<Order> Get()
        //{
        //    try
        //    {
        //        List<Order> lo = new List<Order>();
        //        Order O = new Order();
        //        lo = O.Read();
        //        return lo;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("בעיה בשליפת נתונים");
        //    }
        //}


        //[HttpGet]
        //[Route("api/phone")]
        //public IEnumerable<Phone> Get(string Filter)
        //{
        //    try
        //    {
        //        List<Phone> Lp = new List<Phone>();
        //        Phone P = new Phone();
        //        Lp = P.ReadFilterOut(Filter);
        //        return Lp;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("בעיה בשליפת נתונים");
        //    }

        //}
    }
}
