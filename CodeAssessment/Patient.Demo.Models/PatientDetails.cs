using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Demo.Models
{
    public class PatientDetails
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Details { get; set; }

        //public TelephoneNumbers TelephoneNumbers { get; set; }
        
    }
}
