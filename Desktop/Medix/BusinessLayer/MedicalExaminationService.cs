using Model;
using Model.Repositories;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class MedicalExaminationService : Service<MedicalExamination, int>, IMedicalExaminationService
    {
        IMedicalExaminationRepository repository { get; set; }
        
        public List<MedicalExamination> GetAllNonExaminedExaminationsForDoctor(int id)
        {
            return repository.GetAllNonExaminedExaminationsForDoctor(id);
        }
    }
}
