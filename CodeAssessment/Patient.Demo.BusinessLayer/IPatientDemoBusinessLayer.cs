using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient.Demo.Models;

namespace Patient.Demo.BusinessLayer
{
    public interface IPatientDemoBusinessLayer
    {
        Patient.Demo.Models.PatientDetails GetPatientDetails(int id);
        void AddPatient(PatientDetails patientDetails);
    }
}
