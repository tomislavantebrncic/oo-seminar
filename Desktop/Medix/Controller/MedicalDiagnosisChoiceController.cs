using BaseLib;
using BusinessLayer;
using Model;
using System.Collections.Generic;
using UoW;

namespace Controller
{
    public class MedicalDiagnosisChoiceController : BaseController, IMedicalDiagnosisController
    {
        private MedicalDiagnosis _diagnosis;
        private readonly IServiceFactory _serviceFactory = null;
        private IDiagnosisChoiceView _frm;

        private IDiagnosisService _service;
        List<MedicalDiagnosis> listDiagnosis;

        public MedicalDiagnosisChoiceController(MedicalDiagnosis diagnosis, IServiceFactory inServiceFactory) : base()
        {
            _serviceFactory = inServiceFactory;
            _diagnosis = diagnosis;
            _service = _serviceFactory.createMedicalDiagnosisService(_unitOfWork);
            listDiagnosis = _service.GetAll();
        }


        public void ViewDiagnosisChoice(IDiagnosisChoiceView inForm)
        {
            _frm = inForm;
            inForm.Update(listDiagnosis);
            inForm.ShowModales(_diagnosis);
            
        }

        public List<MedicalDiagnosis> FindDiagnosisByName(string name)
        {
            return _service.FindDiagnosisByName(name);
        }

        public MedicalDiagnosis ChooseDiagnosis(MedicalDiagnosis diagnosis)
        {
            _diagnosis = diagnosis;
            return diagnosis;
        }
    }
}
