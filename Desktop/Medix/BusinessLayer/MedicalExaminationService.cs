using Model;
using Model.Repositories;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class MedicalExaminationService : Service<MedicalExamination, int>, IMedicalExaminationService
    {
        public MedicalExaminationService(IMedicalExaminationRepository inRepository) {
            repository = inRepository;
        }
        
        public List<MedicalExamination> GetAllNonExaminedExaminationsForDoctor(int id)
        {
            return ((IMedicalExaminationRepository)repository).GetAllNonExaminedExaminationsForDoctor(id);
        }
    }
}
