using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLib;
using DataAccess.Mappings;
using Model;
using Model.Repositories;
using NHibernate;

namespace DataAccess
{
    class MedicalFindingRepository : Repository<MedicalFinding, int>, IMedicalFindingRepository
    {
        public MedicalFindingRepository(IUnitOfWork inUnitOfWork) : base(inUnitOfWork)
        {
        }

        public List<MedicalFinding> FindingsForPatient(int patientId)
        {
            return FilterGetAll()
                    .Where(x => x.Patient.Id == patientId)
                    .OrderBy(x => x.Date)
                    .ToList();
        }
    }
}
