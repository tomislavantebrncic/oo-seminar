using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IWaitingRoomController : IBaseController
    {
        void ViewWaitingRoom(IWaitingRoomView inForm, IMainFormController mainController);
        void AddExamination();
        void SetExamined(MedicalExamination examination);
        void ShowStatistics();
        void SetPatient(Patient patient);
        void ShowHistory();
        void Examine(MedicalExamination examination);
    }
}
