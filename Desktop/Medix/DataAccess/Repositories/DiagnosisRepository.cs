using BaseLib;
using DataAccess.Mappings;
using Model;
using Model.RepositoryInterfaces;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class DiagnosisRepository : Repository<MedicalDiagnosis, int>, IDiagnosisRepository
    {
        public DiagnosisRepository(IUnitOfWork inUnitOfWork) : base(inUnitOfWork)
        {
        }

        public List<MedicalDiagnosis> FindByName(string name)
        {
            return FilterGetAll()
                    .Where(x => (x.NameHRV.Contains(name) || x.NameLAT.Contains(name)))
                    .OrderBy(x => x.NameHRV)
                    .ToList();
        }
    }
}
