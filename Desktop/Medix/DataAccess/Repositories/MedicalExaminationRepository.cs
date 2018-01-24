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
    public class MedicalExaminationRepository : Repository<MedicalExamination, int>, IMedicalExaminationRepository
    {
        public List<MedicalExamination> GetAllExaminedByDate(int inDoctorId, DateTime date)
        {
            using (ISession nhibernateSession = NHibernateHelper.OpenSession())
            {
                return nhibernateSession.Query<MedicalExamination>()
                    .Where(x => (x.Doctor.Id == inDoctorId && x.Examined &&
                    x.ExaminationDate < DateTime.Today.AddDays(1)))
                   .OrderBy(x => x.ExaminationDate)
                   .ToList<MedicalExamination>();
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
