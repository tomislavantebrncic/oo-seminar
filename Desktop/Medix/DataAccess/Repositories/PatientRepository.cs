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
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    IQuery query = session.CreateQuery(
                            "FROM Patient WHERE PatientId = :patient");
                    query.SetString("patient", inPatientId);

                    IList<Patient> foundPatients = query.List<Patient>();

                    if (foundPatients.Count == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return foundPatients[0];
                    }
                }
            }
        }
    }
}
