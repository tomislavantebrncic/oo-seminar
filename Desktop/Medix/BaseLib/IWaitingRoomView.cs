using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IWaitingRoomView
    {
        void ShowModaless(Doctor inDoctor, IMainFormController inMainController, IWaitingRoomController inWaitingRoomController, List<MedicalExamination> inListExaminations);
        void Update(List<MedicalExamination> inListExaminations);
    }
}
