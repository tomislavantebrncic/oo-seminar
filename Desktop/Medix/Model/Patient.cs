using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patient : Person
    {
        private string _patientID;
        private IList<MedicalFinding> _medicalHistory;
        private Address _address;

        public virtual string PatientID
        {
            get { return _patientID; }
            set { _patientID = value; }
        }
        public virtual IList<MedicalFinding> MedicalHistory
        {
            get { return _medicalHistory; }
            set { _medicalHistory = value; }
        }
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
            if (!(obj.GetType() == typeof(Patient)))
                return false;
            Patient p = (Patient)obj;
            return p.OIB.Equals(this.OIB);
        }

        public override int GetHashCode()
        {
            var hashCode = -479751879;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_patientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<IList<MedicalFinding>>.Default.GetHashCode(_medicalHistory);
            hashCode = hashCode * -1521134295 + EqualityComparer<Address>.Default.GetHashCode(_address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PatientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<IList<MedicalFinding>>.Default.GetHashCode(MedicalHistory);
            hashCode = hashCode * -1521134295 + EqualityComparer<Address>.Default.GetHashCode(Address);
            return hashCode;
        }
    }
}
