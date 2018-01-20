using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IPatientRepository
    {
        Patient Get(string inPatientId);
        IList<Patient> GetAllByLastName(string inLastName);
    }
}
