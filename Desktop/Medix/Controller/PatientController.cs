using BaseLib;
using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoW;

namespace Controller
{
    public class PatientController : BaseController, IPatientController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IServiceFactory _serviceFactory = null;
        private readonly IMedicalExaminationController _medicalExaminationController = null;

        public PatientController(IWindowFormsFactory inFormsFactory, IServiceFactory inServiceFactory, IMedicalExaminationController inController) : base()
        {
            _formsFactory = inFormsFactory;
            _serviceFactory = inServiceFactory;
            _medicalExaminationController = inController;
        }

        public void ViewSelectPatient(ISelectPatientView inForm)
        {
            inForm.ShowModaless(this);
        }

        public IList<Patient> SearchPatients(string inLastName)
        {
            var patientService = _serviceFactory.createPatientService(_unitOfWork);

            return patientService.GetAllByLastName(inLastName);
        }

        public void UpdateAddMedicalExaminationPatient(Patient inPatient)
        {
            _medicalExaminationController.UpdateInfo(inPatient);
        }
    }
}
