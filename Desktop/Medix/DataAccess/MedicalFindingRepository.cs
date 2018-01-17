using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Repositories;
using NHibernate;

namespace DataAccess
{
    class MedicalFindingRepository : IMedicalFindingRepository
    {
        public MedicalFindingRepository()
        {
        }

        public void SaveFinding(MedicalFinding finding)
        {
            using (ISession nhibernateSession = SessionManager.GetCurrentSession())
            {
                nhibernateSession.BeginTransaction();
                nhibernateSession.SaveOrUpdate(finding);
                nhibernateSession.Transaction.Commit();
            }
        }
    }
}
