using BaseLib;
using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using UoW;

namespace Controller
{
    public class MedicalExaminationController : Subject, IMedicalExaminationController
    {
        private IUnitOfWork _unitOfWork;
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IServiceFactory _serviceFactory = null;
        private IAddMedicalExaminationView _form = null;

        public MedicalExaminationController(IObserver inObserver, IWindowFormsFactory inFormsFactory, IServiceFactory inServiceFactory)
        {
            _unitOfWork = new UnitOfWork();
            _formsFactory = inFormsFactory;
            _serviceFactory = inServiceFactory;
            Attach(inObserver);
        }

        public void AddNewMedicalExamination(IAddMedicalExaminationView inForm, Doctor inDoctor)
        {
            _form = inForm;

            List<ExaminationType> typesList = _serviceFactory.CreateExaminationTypeService(_unitOfWork).GetAll();

            if (inForm.ShowViewModal(typesList))
            {
                try
                {
                    ExaminationType examinationType = inForm.ExaminationType;
                    string PatientId = inForm.PatientId;
                    string FirstName = inForm.PatientFirstName;
                    string LastName = inForm.PatientLastName;
                    string OIB = inForm.PatientOIB;
                    DateTime DateOfBirth;
                    DateTime.TryParseExact(inForm.PatientDateOfBirth, "dd.MM.yyyy", null, DateTimeStyles.None, out DateOfBirth);

                    var patient = _serviceFactory.createPatientService(_unitOfWork).GetByOIB(OIB);

                    if (patient == null)
                    {
                        patient = new Patient(FirstName, LastName, OIB, DateOfBirth, PatientId);
                    }                

                    MedicalExamination medicalExamination = new MedicalExamination(inDoctor, patient, DateTime.Now, examinationType);

                    IMedicalExaminationService medicalExaminationService = _serviceFactory.createMedicalExaminationService(_unitOfWork);

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
            var patientController = new PatientController(_formsFactory, _serviceFactory, this);

            var newFrm = _formsFactory.CreateSelectPatientView();

            patientController.ViewSelectPatient(newFrm);
        }

        public void UpdateInfo(Patient inPatient)
        {
            _form.UpdateInfo(inPatient);
        }
        
        public void Close()
        {
            _unitOfWork.Commit();
            _unitOfWork = new UnitOfWork();
        }
    }
}
