using BaseLib;
using BusinessLayer;
using Model;

namespace Controller
{
    public class MedicalFindingFormController : IMedicalFindingFormController
    {
        IServiceFactory _serviceFactory = null;
        MedicalExamination examination;

        public MedicalFindingFormController(IServiceFactory inServiceFactory, MedicalExamination inExamination)
        {
            _serviceFactory = inServiceFactory;
            examination = inExamination;
        }

        public void AddNewMedicalFinding(IMedicalFindingView inForm)
        {
            inForm.ShowModaless(examination);
        }

        public void saveFinding(MedicalFinding finding)
        {
            IMedicalFindingService service = _serviceFactory.createMedicalFindingService();
            service.Add(finding);
        }
    }
}
