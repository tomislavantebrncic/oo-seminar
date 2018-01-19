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
    public class MedicalExaminationRepository : IMedicalExaminationRepository
    {
        public void Add(MedicalExamination inMedicalExamination)
        {
            using (ISession session = SessionManager.GetCurrentSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(inMedicalExamination);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        public List<MedicalExamination> GetAllNonExaminedExaminationsForDoctor(int inDoctorId)
        {
            using (ISession nhibernateSession = NHibernateHelper.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                    "FROM MedicalExamination WHERE Doctor_id = :doctor AND Examined = false");
                query.SetInt32("doctor", inDoctorId);

                return query.List<MedicalExamination>().ToList();
            }
        }
    }
}
