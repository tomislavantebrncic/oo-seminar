using BaseLib;
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
        private readonly IWaitingRoomRepository _wrRepository = null;

        public MainFormController(IWindowFormsFactory inFormsFactory, IWaitingRoomRepository inWaitingRoomRepository)
        {
            _formsFactory = inFormsFactory;
            _wrRepository = inWaitingRoomRepository;
        }

        public void CheckAuthentication()
        {

        }

        public void ShowWaitingRoom()
        {
            var wrController = new WaitingRoomController();

            var newFrm = _formsFactory.CreateWaitingRoomView();

            wrController.ViewWaitingRoom(newFrm, _wrRepository, this);
        }

        public void CreateNewExamination(string patientId)
        {
            var newFrm = _formsFactory.CreateNewExaminationView();
        }
    }
}
