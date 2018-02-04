using Model;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IPatientService : IService<Patient, int>
    {
        List<Patient> GetAllByLastName(string inLastName);
        Patient GetByOIB(string oIB);
        Patient Add(string inFirstName, string inLastname, string OIB, DateTime inDate, string inId);
    }
}
