using System;
using System.Collections.Generic;
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

        public Patient Add(string inFirstName, string inLastName, string OIB, DateTime inDate, string inId)
        {
            if (OIB.Length != 11 || !IsDigitsOnly(OIB))
            {
                throw new Exception("Neispravan OIB.");
            }
            else if (DateTime.Today.Subtract(inDate).Days > 0)
            {
                throw new Exception("Neispravan datum.");
            }
            return null;
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
