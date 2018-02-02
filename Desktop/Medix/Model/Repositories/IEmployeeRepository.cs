using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee, int>
    {
        Employee GetByUsernameAndPassword(string inUsername, string inPassword);
    }
}
