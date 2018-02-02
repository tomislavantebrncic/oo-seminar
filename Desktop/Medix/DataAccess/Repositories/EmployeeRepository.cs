using BaseLib;
using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EmployeeRepository : Repository<Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWork inUnitOfWork) : base(inUnitOfWork)
        {
        }

        public Employee GetByUsernameAndPassword(string inUsername, string inPassword)
        {
            return FilterGetAll()
                .Where(e => e.EmployeeID.Equals(inUsername) && e.Password.Equals(inPassword))
                .FirstOrDefault();
        }
    }
}
