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
    }
}
