using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Mappings;
using Model;
using Model.Repositories;
using NHibernate;

namespace DataAccess
{
    class MedicalFindingRepository : Repository<MedicalFinding, int>, IMedicalFindingRepository
    {
        public List<MedicalFinding> FindingsForPatient(int patientId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    return session.Query<MedicalFinding>()
                        .Where(x => x.Patient.Id == patientId)
                        .OrderBy(x => x.Date)
                        .ToList<MedicalFinding>();
                }
            }
        }
    }
}
