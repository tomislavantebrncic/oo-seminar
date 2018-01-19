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
    public class PatientRepository : IPatientRepository
    {
        public Patient Get(string inPatientId)
        {
            using (ISession session = SessionManager.GetCurrentSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var patient = session.Query<Patient>()
                        .Where(p => p.PatientID.Equals(inPatientId))
                        .First();

                    transaction.Commit();

                    return patient;
                }
            }
        }
    }
}
