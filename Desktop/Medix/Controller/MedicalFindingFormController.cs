using BaseLib;
using BusinessLayer;
using Model;
using UoW;

namespace Controller
{
    public class MedicalFindingFormController : BaseController, IMedicalFindingFormController
    {
        private readonly IServiceFactory _serviceFactory = null;
        private readonly IWindowFormsFactory _formsFactory = null;
        MedicalExamination examination;

        private IMedicalFindingService findingService = null;

        public MedicalFindingFormController(IServiceFactory inServiceFactory, MedicalExamination inExamination, IWindowFormsFactory inFormsFactory, IObserver observer) : base()
        {
            _formsFactory = inFormsFactory;
            _serviceFactory = inServiceFactory;
            examination = inExamination;
            Attach(observer);
        }

        public void AddMedicalFinding(IMedicalFindingView inForm)
        {
            findingService = _serviceFactory.createMedicalFindingService(_unitOfWork);

            inForm.ShowModaless(examination);
        }

        public void saveFinding(MedicalFinding finding)
        {
            findingService.Add(finding);
        }

        public void ChooseDiagnosis(MedicalFinding finding)
        {
            var mdController = new MedicalDiagnosisChoiceController(finding.MedicalDiagnosis, _serviceFactory);
            var newForm = _formsFactory.CreateDiagnosisChoiceView(mdController);
            mdController.ViewDiagnosisChoice(newForm);
        }
    }
}
