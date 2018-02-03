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
        public virtual IList<MedicalFinding> MedicalHistory { get; set; }
        private Address _address;

        public virtual Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public Patient()
        {

        }

        //public Patient(int inID, string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inPatientID) : base(inID, inFirstName, inLastName, inOIB, inDateOfBirth)
        //{
        //    PatientID = inPatientID;
        //}

        public Patient(string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inPatientID) : base(inFirstName, inLastName, inOIB, inDateOfBirth)
        {
            PatientID = inPatientID;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Patient p = (Patient)obj;
            return p.OIB.Equals(this.OIB);
        }
    }
}
