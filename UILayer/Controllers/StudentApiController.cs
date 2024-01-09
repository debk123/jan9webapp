using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UILayer.Controllers
{
    public class StudentApiController : ApiController
    {
        [HttpGet]
        [Route("GetStudent")]
        public IHttpActionResult Getstudents()
        {
            List<string> rec = new List<string>() { "manoj", "suresh" };

            return Ok(rec);
        }
    }
}
