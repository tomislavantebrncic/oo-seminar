using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IMedicalExaminationRepository : IRepository<MedicalExamination, int>
    {
        List<MedicalExamination> GetAllByDoctorAndNonExamined(int inDoctorId);
        List<MedicalExamination> GetAllByDateAndExamined(int inDoctorId, DateTime date);
    }
}
