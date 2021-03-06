﻿using BaseLib;
using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using UoW;

namespace Controller
{
    public class MedicalExaminationController : BaseController, IMedicalExaminationController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IServiceFactory _serviceFactory = null;
        private IAddMedicalExaminationView _form = null;

        public MedicalExaminationController(IObserver inObserver, IWindowFormsFactory inFormsFactory, IServiceFactory inServiceFactory)
        {
            _formsFactory = inFormsFactory;
            _serviceFactory = inServiceFactory;
            Attach(inObserver);
        }

        public void AddNewMedicalExamination(IAddMedicalExaminationView inForm)
        {
            _form = inForm;

            List<ExaminationType> typesList = _serviceFactory.CreateExaminationTypeService(_unitOfWork).GetAll();

            if (inForm.ShowViewModal(typesList))
            {
                try
                {
                    bool emergency = inForm.Emergency;
                    ExaminationType examinationType = inForm.ExaminationType;
                    string PatientId = inForm.PatientId;
                    string FirstName = inForm.PatientFirstName;
                    string LastName = inForm.PatientLastName;
                    string OIB = inForm.PatientOIB;
                    string address = inForm.Address;
                    string city = inForm.City;
                    string zipCode = inForm.ZipCode;
                    DateTime DateOfBirth;
                    DateTime.TryParseExact(inForm.PatientDateOfBirth, "dd.MM.yyyy", null, DateTimeStyles.None, out DateOfBirth);

                    var patientService = _serviceFactory.createPatientService(_unitOfWork);

                    var patient = patientService.GetByOIB(OIB);

                    if (patient == null)
                    {
                        patient = patientService.Add(FirstName, LastName, OIB, DateOfBirth, PatientId, address, city, zipCode);
                    }

                    Employee employee = LoggedIn.GetEmployee();
                    WaitingRoom waitingRoom = LoggedIn.GetWaitingRoom();

                    IMedicalExaminationService medicalExaminationService = _serviceFactory.createMedicalExaminationService(_unitOfWork);

                    MedicalExamination medicalExamination = medicalExaminationService.Add(patient, examinationType, emergency);
                    //WaitingRoom waitingRoom = LoggedIn.GetEmployee().WaitingRoom;

                    //var service = _serviceFactory.CreateWaitingRoomService(_unitOfWork);

                    //WaitingRoom wr = service.GetById(waitingRoom.Id);
                    //WaitingRoom wr = new WaitingRoom(new List<MedicalExamination>(), "Kardio");
                    //wr.AddExamination(medicalExamination);
                    //service.Add(wr);

                    NotifyObservers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
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
        
    }
}
