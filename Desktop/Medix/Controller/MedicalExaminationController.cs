using BaseLib;
using BusinessLayer;
using Model;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Controller
{
    public class MedicalExaminationController : Subject, IMedicalExaminationController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IServiceFactory _serviceFactory = null;

        public MedicalExaminationController(IObserver inObserver, IWindowFormsFactory inFormsFactory, IServiceFactory inServiceFactory)
        {
            _formsFactory = inFormsFactory;
            _serviceFactory = inServiceFactory;
            Attach(inObserver);
        }
        
        public void AddNewMedicalExamination(IAddMedicalExaminationView inForm, Doctor inDoctor)
        {
            if (inForm.ShowViewModal())
            {
                try
                {
                    string PatientId = inForm.PatientId;
                    string FirstName = inForm.PatientFirstName;
                    string LastName = inForm.PatientLastName;
                    string OIB = inForm.PatientOIB;
                    DateTime DateOfBirth = DateTime.ParseExact(inForm.PatientDateOfBirth, "dd.MM.yyyy", CultureInfo.InvariantCulture);

                    Patient patient = new Patient(FirstName, LastName, OIB, DateTime.Now, PatientId);
                
                    MedicalExamination medicalExamination = new MedicalExamination(inDoctor, patient, DateTime.Now, null);

                    IMedicalExaminationService medicalExaminationService = _serviceFactory.createMedicalExaminationService();

                    medicalExaminationService.Add(medicalExamination);

                    NotifyObservers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public void ShowSelectPatient()
        {
            var patientController = new PatientController(_formsFactory, _serviceFactory);

            var newFrm = _formsFactory.CreateSelectPatientView();

            patientController.ViewSelectPatient(newFrm);
        }

        
    }
}
