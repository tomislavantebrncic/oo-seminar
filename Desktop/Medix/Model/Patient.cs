using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patient : Person
    {
        public virtual string PatientID { get; set; }

        public Patient()
        {

        }

        public Patient(int inID, string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inPatientID) : base(inID, inFirstName, inLastName, inOIB, inDateOfBirth)
        {
            PatientID = inPatientID;
        }
    }
}
