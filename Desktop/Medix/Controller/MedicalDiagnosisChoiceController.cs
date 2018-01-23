using BaseLib;
using BusinessLayer;
using Model;
using System.Collections.Generic;

namespace Controller
{
    public class MedicalDiagnosisChoiceController : IMedicalDiagnosisController
    {
        private MedicalDiagnosis _diagnosis;
        private readonly IServiceFactory _serviceFactory = null;
        private IDiagnosisChoiceView _frm;
        public MedicalDiagnosisChoiceController(MedicalDiagnosis diagnosis, IServiceFactory inServiceFactory)
        {
            _serviceFactory = inServiceFactory;
            _diagnosis = diagnosis;
        }

        public void ChooseDiagnosis()
        {
            
        }

        public void ViewDiagnosisChoice(IDiagnosisChoiceView inForm)
        {
            var medicalDiagnosisService = _serviceFactory.createMedicalDiagnosisService();

            List<MedicalDiagnosis> listDiagnosis = medicalDiagnosisService.GetAll();

            _frm = inForm;
            inForm.Update(listDiagnosis);
            inForm.ShowModales(_diagnosis);
            
        }
    }
}
