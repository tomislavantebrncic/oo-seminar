using BaseLib;
using BusinessLayer;
using Model;

namespace Controller
{
    public class MedicalFindingFormController : IMedicalFindingFormController
    {
        private readonly IServiceFactory _serviceFactory = null;
        private readonly IWindowFormsFactory _formsFactory = null;
        MedicalExamination examination;

        private IMedicalFindingService findingService = null;

        public MedicalFindingFormController(IServiceFactory inServiceFactory, MedicalExamination inExamination, IWindowFormsFactory inFormsFactory)
        {
            _formsFactory = inFormsFactory;
            _serviceFactory = inServiceFactory;
            examination = inExamination;
        }

        public void AddMedicalFinding(IMedicalFindingView inForm)
        {
            findingService = _serviceFactory.createMedicalFindingService();

            //_frm = inForm;

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
