using Model;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IMedicalExaminationService : IService<MedicalExamination, int>
    {
        List<MedicalExamination> GetAllNonExaminedExaminationsForDoctor(int id);
    }
}