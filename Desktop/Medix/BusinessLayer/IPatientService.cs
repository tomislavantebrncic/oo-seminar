using Model;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IPatientService
    {
        List<Patient> GetAllByLastName(string inLastName);
    }
}
