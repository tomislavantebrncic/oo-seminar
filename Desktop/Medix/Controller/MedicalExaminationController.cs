using BaseLib;
using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class MedicalExaminationController : Subject, IMedicalExaminationController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IRepositoryFactory _repositoryFactory = null;

        public MedicalExaminationController(IObserver inObserver, IWindowFormsFactory inFormsFactory, IRepositoryFactory inRepositoryFactory)
        {
            _formsFactory = inFormsFactory;
            _repositoryFactory = inRepositoryFactory;
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

                    IMedicalExaminationRepository medicalExaminationRepository = _repositoryFactory.CreateMedicalExaminationRepository();

                    medicalExaminationRepository.Add(medicalExamination);

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
            var patientController = new PatientController(_formsFactory, _repositoryFactory);

            var newFrm = _formsFactory.CreateSelectPatientView();

            patientController.ViewSelectPatient(newFrm);
        }

        
    }
}
