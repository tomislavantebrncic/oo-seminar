using BaseLib;
using BusinessLayer;
using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class WaitingRoomController : IWaitingRoomController, IObserver
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IServiceFactory _repositoryFactory = null;
        private readonly Doctor _doctor = null;
        private IWaitingRoomView _frm;

        public WaitingRoomController(Doctor inDoctor, IWindowFormsFactory inFormsFactory, IServiceFactory inRepositoryFactory)
        {
            _doctor = inDoctor;
            _formsFactory = inFormsFactory;
            _repositoryFactory = inRepositoryFactory;
        }

        public void ViewWaitingRoom(IWaitingRoomView inForm, IMainFormController mainController)
        {
            var medicalExaminationRepository = _repositoryFactory.createMedicalExaminationService();

            List<MedicalExamination> listExaminations = medicalExaminationRepository.GetAllNonExaminedExaminationsForDoctor(_doctor.Id);

            _frm = inForm;

            inForm.ShowModaless(_doctor, mainController, this, listExaminations);
        }

        public void AddExamination()
        {
            var meController = new MedicalExaminationController(this, _formsFactory, _repositoryFactory);

            var newFrm = _formsFactory.CreateAddMedicalExaminationView(meController);

            meController.AddNewMedicalExamination(newFrm, _doctor);
        }

        public void Update()
        {
            var medicalExaminationRepository = _repositoryFactory.createMedicalExaminationService();

            List<MedicalExamination> listExaminations = medicalExaminationRepository.GetAllNonExaminedExaminationsForDoctor(_doctor.Id);

            _frm.Update(listExaminations);
        }
    }
}
