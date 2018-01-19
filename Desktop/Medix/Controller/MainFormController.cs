using BaseLib;
using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class MainFormController : IMainFormController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IRepositoryFactory _repositoryFactory = null;
        private Doctor _doctor = null;

        public MainFormController(IWindowFormsFactory inFormsFactory, IRepositoryFactory inRepositoryFactory)
        {
            _repositoryFactory = inRepositoryFactory;
            _formsFactory = inFormsFactory;
        }

        public Doctor CheckAuthentication(string inId, string inPassword)
        {
            var doctorRepository = _repositoryFactory.CreateDoctorRepository();

            _doctor = doctorRepository.GetDoctorWithIdAndPassword(inId, inPassword);

            return _doctor;
        }

        public void ShowWaitingRoom(Doctor doctor)
        {
            var wrController = new WaitingRoomController();

            var newFrm = _formsFactory.CreateWaitingRoomView();

            wrController.ViewWaitingRoom(doctor, _repositoryFactory.CreateMedicalExaminationRepository(), newFrm, this);
        }

        public void CreateNewExamination(string patientId)
        {

        }

        public void Examine(Patient inPatient)
        {
            //MessageBox.Show(inPatient.ToString());
        }

        public void AddExamination()
        {
            var meController = new MedicalExaminationController(_repositoryFactory);

            var newFrm = _formsFactory.CreateAddMedicalExaminationView();

            meController.AddNewMedicalExamination(newFrm);
        }
    }
}
