using System.Collections.Generic;
using Model;
using Model.Repositories;

namespace BusinessLayer
{
    public class MedicalFindingService : Service<MedicalFinding, int>, IMedicalFindingService
    {
        public MedicalFindingService(IMedicalFindingRepository inRepository)
        {
            repository = inRepository;
        }

        public List<MedicalFinding> findingsForPatient(Patient patient)
        {
            return ((IMedicalFindingRepository)repository).FindingsForPatient(patient.Id);
        }
    }
}
