using BaseLib;
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
        public MedicalExaminationRepository(IUnitOfWork inUnitOfWork) : base(inUnitOfWork)
        {
        }

        public List<MedicalExamination> GetAllByDateAndExamined(int inDoctorId, DateTime date)
        {
            return FilterGetAll()
                    .Where(e => e.Doctor.Id == inDoctorId)
                    .Where(e => e.Examined)
                    .Where(e => e.ExaminationDate < DateTime.Today.AddDays(1))
                    .OrderBy(e => e.ExaminationDate)
                    .ToList();
        }

        public List<MedicalExamination> GetAllByDoctorAndNonExamined(int inDoctorId)
        {
            return FilterGetAll()
                    .Where(e => e.Doctor.Id == inDoctorId)
                    .Where(e => !e.Examined)
                    .ToList();
        }
    }
}
