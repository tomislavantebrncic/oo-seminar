using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IWindowFormsFactory
    {
        IWaitingRoomView CreateWaitingRoomView();
        IAddMedicalExaminationView CreateAddMedicalExaminationView(IMedicalExaminationController inMedicalExaminationController);
        IMedicalFindingView CreateNewMedicalFindingView(IMedicalFindingFormController controller, IWaitingRoomController waitingRoomController);
        ISelectPatientView CreateSelectPatientView();
        IDiagnosisChoiceView CreateDiagnosisChoiceView(IMedicalDiagnosisController inController);
    }
}
