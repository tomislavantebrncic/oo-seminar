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
    public class WaitingRoomController
    {


        public void ViewWaitingRoom(Doctor inDoctor, IWaitingRoomView inForm, IWaitingRoomRepository waitingRoomRepository, IMainFormController mainController)
        {
            List<MedicalExamination> listExaminations = waitingRoomRepository.getAllExaminations();

            inForm.ShowModaless(inDoctor, mainController, listExaminations);
        }
    }
}
