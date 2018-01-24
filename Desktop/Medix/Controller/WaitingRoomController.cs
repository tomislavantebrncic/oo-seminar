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
        private readonly IServiceFactory _serviceFactory = null;
        private Employee _employee = null;
        private IWaitingRoomView _frm;

        public WaitingRoomController(Employee inEmployee, IWindowFormsFactory inFormsFactory, IServiceFactory inServiceFactory)
        {
            _employee = inEmployee;
            _formsFactory = inFormsFactory;
            _serviceFactory = inServiceFactory;
        }

        public void ViewWaitingRoom(IWaitingRoomView inForm, IMainFormController mainController)
        {

            bool enabled = (_employee is Doctor) ? true : false;

            var medicalExaminationService = _serviceFactory.createMedicalExaminationService();

            List<MedicalExamination> listExaminations = medicalExaminationService.GetAllNonExaminedExaminationsForDoctor(_employee.Id);
            //List<MedicalExamination> listExaminations = _employee.WaitingRoom.Examinations.ToList();

            _frm = inForm;

            inForm.ShowModaless(_employee.ToString(), _employee.WaitingRoom.Name, mainController, this, listExaminations);
        }

        public void AddExamination()
        {
            var meController = new MedicalExaminationController(this, _formsFactory, _serviceFactory);

            var newFrm = _formsFactory.CreateAddMedicalExaminationView(meController);

            meController.AddNewMedicalExamination(newFrm, (Doctor)_employee, _employee.WaitingRoom.Id);
        }

        public void Update()
        {
            var medicalExaminationService = _serviceFactory.createMedicalExaminationService();

            List<MedicalExamination> listExaminations = medicalExaminationService.GetAllNonExaminedExaminationsForDoctor(_employee.Id);

            _frm.Update(listExaminations);
        }

        public void SetExamined(MedicalExamination examination)
        {
            var medicalExaminationService = _serviceFactory.createMedicalExaminationService();
            examination.SetExamined();
            medicalExaminationService.Update(examination);
            //update
        }

        public void ShowStatistics()
        {
            var statisticsService = _serviceFactory.createStatisticsService();
            var form = _formsFactory.CreateStatisticsView(statisticsService
                .CalculateStatistics(DateTime.Now, (Doctor)_employee));
            form.ShowModaless();
        }
    }
}
