using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Patient.Demo.BusinessLayer;
using Patient.Demo.Models;

namespace Patient.Demo.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPatientDemoBusinessLayer _patientDemoBusinessLayer;

        public HomeController(IPatientDemoBusinessLayer patientDemoBusinessLayer)
        {
            _patientDemoBusinessLayer = patientDemoBusinessLayer;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Get()
        {
           var data =  _patientDemoBusinessLayer.GetPatientDetails(1);
            return PartialView("_PatientDetails", data);
        }

        [HttpPost]
        public void Save(PatientDetails patientDetails)
        {
            _patientDemoBusinessLayer.AddPatient(patientDetails);
        }
    }
}