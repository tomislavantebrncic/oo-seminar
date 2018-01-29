using BaseLib;
using DataAccess.Mappings;
using Model;
using Model.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DoctorRepository : Repository<Doctor, int>, IDoctorRepository 
    {
        public DoctorRepository(IUnitOfWork inUnitOfWork) : base(inUnitOfWork)
        {
        }

        public Doctor GetByEmployeeId(string employeeId)
        {
            return FilterGetAll()
                .Where(d => d.EmployeeID.Equals(employeeId))
                .FirstOrDefault();
        }

        public Doctor GetByUsernameAndPassword(string inId, string inPassword)
        {
            return FilterGetAll()
                    .Where(d => d.EmployeeID.Equals(inId))
                    .Where(d => d.Password.Equals(inPassword))
                    .FirstOrDefault();
        }
    }
}
