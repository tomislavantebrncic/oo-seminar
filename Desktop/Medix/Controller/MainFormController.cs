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

namespace Controller
{
    public class MainFormController : IMainFormController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IServiceFactory _serviceFactory = null;
        private Doctor _doctor = null;

        public MainFormController(IWindowFormsFactory inFormsFactory, IServiceFactory inServiceFactory)
        {
            _serviceFactory = inServiceFactory;
            _formsFactory = inFormsFactory;
        }

        public bool CheckAuthentication(string inId, string inPassword)
        {
            var doctorService = _serviceFactory.createDoctorService();

            _doctor = doctorService.GetDoctorWithIdAndPassword(inId, inPassword);

            return (_doctor != null) ? true : false;
        }

        public void ShowWaitingRoom()
        {
            var wrController = new WaitingRoomController(_doctor, _formsFactory, _serviceFactory);

            var newFrm = _formsFactory.CreateWaitingRoomView();

            wrController.ViewWaitingRoom(newFrm, this);
        }

        public void Examine(MedicalExamination examination)
        {
            var mfController = new MedicalFindingFormController(_serviceFactory, examination, _formsFactory);
            var wrController = new WaitingRoomController(_doctor, _formsFactory, _serviceFactory);
            var newFrm = _formsFactory.CreateNewMedicalFindingView(mfController, wrController);

            mfController.AddMedicalFinding(newFrm);
        }
    }
}
