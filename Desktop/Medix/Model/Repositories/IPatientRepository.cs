using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IPatientRepository : IRepository<Patient,int>
    {
        Patient GetByPatientId(string inPatientId);
        List<Patient> GetAllByLastName(string inLastName);
        Patient GetByOIB(string inOIB);
    }
}
