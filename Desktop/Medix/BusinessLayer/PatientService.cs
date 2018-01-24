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

        public List<Patient> GetAllByLastName(string inLastName)
        {
            return ((IPatientRepository)repository).GetAllByLastName(inLastName);
        }

        public Patient GetByOIB(string inOIB)
        {
            return ((IPatientRepository)repository).GetByOIB(inOIB);
        }
    }
}
