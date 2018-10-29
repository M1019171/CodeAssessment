using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Patient.Demo.Models;

namespace Patient.Demo.WebApi.Controllers
{
    public class PatientController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Good");
        }

        public IHttpActionResult Post([FromBody]PatientDetails  patientDetails)
        {
            return Ok(patientDetails.Forename);
        }
    }
}
