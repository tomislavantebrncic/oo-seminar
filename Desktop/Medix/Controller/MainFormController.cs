using BaseLib;
using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MainFormController : IMainFormController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IMedicalExaminationRepository _medicalExaminationRepository = null;
        private readonly IDoctorRepository _doctorRepository = null;

        public MainFormController(IWindowFormsFactory inFormsFactory, IMedicalExaminationRepository inMedicalExaminationRepository, IDoctorRepository inDoctorRepository)
        {
            _formsFactory = inFormsFactory;
            _medicalExaminationRepository = inMedicalExaminationRepository;
            _doctorRepository = inDoctorRepository;
        }

        public Doctor CheckAuthentication(string inId, string inPassword)
        {
            return _doctorRepository.GetDoctorWithIdAndPassword(inId, inPassword);
        }

        public void ShowWaitingRoom(Doctor doctor)
        {
            var wrController = new WaitingRoomController();

            var newFrm = _formsFactory.CreateWaitingRoomView();

            wrController.ViewWaitingRoom(doctor, _medicalExaminationRepository, newFrm, this);
        }

        public void CreateNewExamination(string patientId)
        {

        }
    }
}
