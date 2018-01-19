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
