using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Demo.DataLayer
{
    public interface IPatientDemoDataAccessLayer  : IDisposable
    {
        Models.PatientDetails GetPatientDetails(int id);
        void InsertPatientDetails(Models.PatientDetails patientDetails);
        IEnumerable<Models.PatientDetails> GetAll();
        void UpdatePatient(Models.PatientDetails patientDetails);     
        bool Delete(int patientId);
        void Save();
    }
}
