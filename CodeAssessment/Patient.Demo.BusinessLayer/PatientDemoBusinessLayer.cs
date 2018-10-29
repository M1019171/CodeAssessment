using Patient.Demo.DataLayer;
using Patient.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Demo.BusinessLayer
{
    public class PatientDemoBusinessLayer : IPatientDemoBusinessLayer
    {
        private readonly IPatientDemoDataAccessLayer _patientDemoDataAccessLayer;
        
        public PatientDemoBusinessLayer(IPatientDemoDataAccessLayer patientDemoDataAccessLayer)
        {
            _patientDemoDataAccessLayer = patientDemoDataAccessLayer;
        }

        public void AddPatient(PatientDetails patientDetails)
        {
            _patientDemoDataAccessLayer.InsertPatientDetails(patientDetails);
            _patientDemoDataAccessLayer.Save();
        }

        public PatientDetails GetPatientDetails(int id)
        {
           return  _patientDemoDataAccessLayer.GetPatientDetails(id);
        }
    }
}
