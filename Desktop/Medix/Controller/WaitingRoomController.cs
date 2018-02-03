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
    public class WaitingRoomController : BaseController, IWaitingRoomController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IServiceFactory _serviceFactory = null;
        private Patient patient = null;

        public WaitingRoomController(IWindowFormsFactory inFormsFactory, IServiceFactory inServiceFactory) : base()
        {
            _formsFactory = inFormsFactory;
            _serviceFactory = inServiceFactory;
        }

        public void ViewWaitingRoom(IWaitingRoomView inForm)
        {
            Attach((IObserver)inForm);
            // start transaction for form
            _unitOfWork.BeginTransaction();

            var employee = LoggedIn.GetEmployee();

            GetUpdatedExaminations(inForm);

            inForm.ShowModaless(employee.ToString(), employee.WaitingRoom.Name, this);
        }

        public void AddExamination(IObserver inForm)
        {
            var employee = LoggedIn.GetEmployee();

            var meController = new MedicalExaminationController(inForm, _formsFactory, _serviceFactory);

            var newFrm = _formsFactory.CreateAddMedicalExaminationView(meController);

            meController.AddNewMedicalExamination(newFrm);
        }

        public void Examine(MedicalExamination examination, IObserver observer)
        {
            if (LoggedIn.GetEmployee() is Doctor)
            {
                var mfController = new MedicalFindingFormController(_serviceFactory, examination, _formsFactory, observer);
                var newFrm = _formsFactory.CreateNewMedicalFindingView(mfController, this);

                mfController.AddMedicalFinding(newFrm);
            }
        }

        public void SetExamined(MedicalExamination examination)
        {
            var medicalExaminationService = _serviceFactory.createMedicalExaminationService(_unitOfWork);
            examination.SetExamined();
            medicalExaminationService.Update(examination);
            NotifyObservers();
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

        public void GetUpdatedExaminations(IWaitingRoomView inForm)
        {
            var medicalExaminationService = _serviceFactory.createMedicalExaminationService(_unitOfWork);
            List<MedicalExamination> listExaminations = medicalExaminationService.GetAllByWaitingRoom(LoggedIn.GetWaitingRoom().Id);
            inForm.Update(listExaminations);
        }
    }
}
