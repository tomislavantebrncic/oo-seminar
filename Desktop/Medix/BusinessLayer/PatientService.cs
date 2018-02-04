using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using Model.Repositories;

namespace BusinessLayer
{
    public class PatientService : Service<Patient, int>, IPatientService
    {
        IPatientRepository _repository { get; set; }

        public PatientService(IPatientRepository inrepository)
        {
            this.repository = inrepository;
        }

        public Patient Add(string inFirstName, string inLastName, string inOIB, DateTime inDate, string inId, string inAddress, string inCity, string inZipCode)
        {
            if (inFirstName.Any(char.IsDigit))
            {
                throw new Exception("Neispravno ime.");
            }
            if (inLastName.Any(char.IsDigit))
            {
                throw new Exception("Neispravno prezime.");
            }
            if (inOIB.Length != 11 || !IsDigitsOnly(inOIB))
            {
                throw new Exception("Neispravan OIB.");
            }
            if (DateTime.Today.Subtract(inDate).Days < 0)
            {
                throw new Exception("Neispravan datum.");
            }
            Patient patient = new Patient(inFirstName, inLastName, inOIB, inDate, inId);
            Address address = new Address(inAddress, inCity, inZipCode);
            patient.Address = address;
            return ((IPatientRepository)repository).Add(patient);
        }

        public List<Patient> GetAllByLastName(string inLastName)
        {
            return ((IPatientRepository)repository).GetAllByLastName(inLastName);
        }

        public Patient GetByOIB(string inOIB)
        {
            return ((IPatientRepository)repository).GetByOIB(inOIB);
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
