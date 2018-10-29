using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient.Demo.Models;

namespace Patient.Demo.DataLayer
{
    public class PatientDemoDataAccessLayer : IPatientDemoDataAccessLayer
    {
        private PatientDemographicsDbContext db = new PatientDemographicsDbContext();

        public PatientDetails GetPatientDetails(int id)
        {
            return new PatientDetails
            {
                Forename = "Ameet",
                LastName = "kumar",
                DateOfBirth = DateTime.UtcNow,
                Gender = "Male",
                //TelephoneNumbers = new TelephoneNumbers
                //{
                //    Home = 123818,
                //    Work = 123123,
                //    Mobile = 1231
                //}
            };
        }
       

        public IEnumerable<Models.PatientDetails> GetAll()
        {
            return db.PatientDetails.ToList();
        }

        public Models.PatientDetails Find(int id)
        {
            return db.PatientDetails.Find(id);
        }

        public void InsertPatientDetails(PatientDetails patientDetails)
        {
            // New entity
            db.PatientDetails.Add(patientDetails);
        }

        public void UpdatePatient(PatientDetails patientDetails)
        {
            // Existing entity
            db.Entry(patientDetails).State = EntityState.Modified;
        }

        public bool Delete(int id)
        {
            try
            {
                Models.PatientDetails person = Find(id);
                db.PatientDetails.Remove(person);
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }


    }
}
