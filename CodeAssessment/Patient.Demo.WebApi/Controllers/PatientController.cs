using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Patient.Demo.BusinessLayer;
using Patient.Demo.Models;

namespace Patient.Demo.WebApi.Controllers
{
    public class PatientController : ApiController
    {
        private readonly IPatientDemoBusinessLayer _patientDemoBusinessLayer;

        public PatientController(IPatientDemoBusinessLayer patientDemoBusinessLayer)
        {
            _patientDemoBusinessLayer = patientDemoBusinessLayer;
        }

        public IHttpActionResult Get()
        {
            var data = _patientDemoBusinessLayer.GetPatientDetails(1);
            return Json(data);
        }


        [HttpPost]
        public IHttpActionResult Post([FromBody]PatientDetails  patientDetails)
        {
            return Ok(patientDetails.Forename);
        }
    }
}
