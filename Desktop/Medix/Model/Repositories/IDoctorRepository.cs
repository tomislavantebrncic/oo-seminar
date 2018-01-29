using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IDoctorRepository : IRepository<Doctor, int>
    {
        Doctor GetByUsernameAndPassword(string inId, string inPassword);
        Doctor GetByEmployeeId(string employeeId);

    }
}
