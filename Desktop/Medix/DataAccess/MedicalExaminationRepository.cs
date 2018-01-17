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
        public List<MedicalExamination> GetAllNonExaminedExaminationsForDoctor(int inDoctorId)
        {
            using (ISession nhibernateSession = SessionManager.GetCurrentSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                    "FROM examination WHERE doctor_id = :doctor AND examined = false");
                query.SetInt32("doctor", inDoctorId);

                return query.List<MedicalExamination>().ToList();
            }
        }
    }
}
