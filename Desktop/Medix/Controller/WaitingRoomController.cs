using BaseLib;
using BusinessLayer;
using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UoW;

namespace Controller
{
    public class WaitingRoomController : BaseController, IWaitingRoomController, IObserver
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IServiceFactory _serviceFactory = null;
        //private Employee _employee = null;
        private IWaitingRoomView _frm;
        private Patient patient = null;

        //public WaitingRoomController(Employee inEmployee, IWindowFormsFactory inFormsFactory, IServiceFactory inServiceFactory) : base()
        //{
        //    _employee = inEmployee;
        //    _formsFactory = inFormsFactory;
        //    _serviceFactory = inServiceFactory;
        //}

        public WaitingRoomController(IWindowFormsFactory inFormsFactory, IServiceFactory inServiceFactory) : base()
        {
            _formsFactory = inFormsFactory;
            _serviceFactory = inServiceFactory;
        }

        public void ViewWaitingRoom(IWaitingRoomView inForm, IMainFormController mainController)
        {
            // start transaction for form
            _unitOfWork.BeginTransaction();

            var employee = LoggedIn.GetEmployee();

            bool enabled = (employee is Doctor) ? true : false;

            var medicalExaminationService = _serviceFactory.createMedicalExaminationService(_unitOfWork);

            List<MedicalExamination> listExaminations = medicalExaminationService.GetAllByDoctorAndNonExamined(employee.Id);
            //List<MedicalExamination> listExaminations = _employee.WaitingRoom.Examinations.ToList();

            _frm = inForm;

            inForm.ShowModaless(employee.ToString(), employee.WaitingRoom.Name, mainController, this, listExaminations);
        }

        public void AddExamination()
        {
            var employee = LoggedIn.GetEmployee();

            var meController = new MedicalExaminationController(this, _formsFactory, _serviceFactory);

            var newFrm = _formsFactory.CreateAddMedicalExaminationView(meController);

            meController.AddNewMedicalExamination(newFrm, (Doctor)employee);
        }

        public void Examine(MedicalExamination examination)
        {
            var mfController = new MedicalFindingFormController(_serviceFactory, examination, _formsFactory);
            var newFrm = _formsFactory.CreateNewMedicalFindingView(mfController, this);

            mfController.AddMedicalFinding(newFrm);
        }

        public void Update()
        {
            var employee = LoggedIn.GetEmployee();

            var medicalExaminationService = _serviceFactory.createMedicalExaminationService(_unitOfWork);

            List<MedicalExamination> listExaminations = medicalExaminationService.GetAllByDoctorAndNonExamined(employee.Id);

            _frm.Update(listExaminations);
        }

        public void SetExamined(MedicalExamination examination)
        {
            var medicalExaminationService = _serviceFactory.createMedicalExaminationService(_unitOfWork);
            examination.SetExamined();
            medicalExaminationService.Update(examination);
            //update
        }

        public void ShowStatistics()
        {
            var employee = LoggedIn.GetEmployee();

            var statisticsService = _serviceFactory.createStatisticsService(_unitOfWork);
            var form = _formsFactory.CreateStatisticsView(statisticsService
                .CalculateStatistics(DateTime.Now, (Doctor)employee));
            form.ShowModaless();
        }

        public void SetPatient(Patient patient)
        {
            this.patient = patient;
        }

        public void ShowHistory()
        {
            if (patient == null)
            {
                MessageBox.Show("Niti jedan pacijent nije odabran.");
                return;
            }
            var history = _serviceFactory.createMedicalFindingService(_unitOfWork).findingsForPatient(patient);
            var form = _formsFactory.CreateMedicalHistoryView(patient, history);
            form.ShowModaless();
        }

    }
}
