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
    public class PatientRepository : Repository<Patient, int>, IPatientRepository
    {
        public PatientRepository(IUnitOfWork inUnitOfWork) : base(inUnitOfWork)
        {
        }

        public List<Patient> GetAllByLastName(string inLastName)
        {
            return FilterGetAll()
                    .Where(p => p.LastName.StartsWith(inLastName))
                    .ToList();
        }

        public Patient GetByPatientId(string inPatientId)
        {
            return FilterGetAll()
                    .Where(p => p.PatientID.Equals(inPatientId))
                    .FirstOrDefault();
        }

        public Patient GetByOIB(string inOIB)
        {
            return FilterGetAll()
                    .Where(p => p.OIB.Equals(inOIB))
                    .FirstOrDefault();
        }
    }
}
