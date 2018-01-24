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
        public Patient GetByPatientId(string inPatientId)
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

        public List<Patient> GetAllByLastName(string inLastName)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        return session.Query<Patient>()
                            .Where(p => p.LastName.StartsWith(inLastName))
                            .ToList();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public Patient GetByOIB(string inOIB)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        return session.Query<Patient>()
                            .Where(p => p.OIB.Equals(inOIB))
                            .FirstOrDefault();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
