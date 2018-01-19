using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IMedicalExaminationRepository
    {
        void Add(MedicalExamination inMedicalExamination);

        List<MedicalExamination> GetAllNonExaminedExaminationsForDoctor(int inDoctorId);
    }
}
