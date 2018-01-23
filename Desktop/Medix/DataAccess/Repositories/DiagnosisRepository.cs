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
        public List<MedicalDiagnosis> FindByName(string name)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    IList<MedicalDiagnosis> foundDiagnosis = session.Query<MedicalDiagnosis>()
                        .Where(x => (x.NameHRV.Contains(name) || x.NameLAT.Contains(name)))
                        .OrderBy(x => x.NameHRV)
                        .ToList<MedicalDiagnosis>();

                    if (foundDiagnosis.Count == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return (List<MedicalDiagnosis>)foundDiagnosis;
                    }
                }
            }
        }
    }
}
