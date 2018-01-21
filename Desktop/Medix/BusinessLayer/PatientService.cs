using System.Collections.Generic;
using Model;
using Model.Repositories;

namespace BusinessLayer
{
    public class PatientService : Service<Patient, int>, IPatientService
    {
        IPatientRepository repository { get; set; }

        public List<Patient> GetAllByLastName(string inLastName)
        {
            return repository.GetAllByLastName(inLastName);
        }
    }
}
