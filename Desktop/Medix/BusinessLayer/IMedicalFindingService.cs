using Model;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IMedicalFindingService : IService<MedicalFinding, int>
    {
        List<MedicalFinding> findingsForPatient(Patient patient);
    }
}