using Model;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IPatientService : IService<Patient, int>
    {
        List<Patient> GetAllByLastName(string inLastName);
        Patient GetByOIB(string oIB);
    }
}
