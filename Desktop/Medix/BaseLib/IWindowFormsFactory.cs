using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IWindowFormsFactory
    {
        IWaitingRoomView CreateWaitingRoomView(IMainFormController inMainFormController);
        IAddMedicalExaminationView CreateAddMedicalExaminationView(IMedicalExaminationController inMedicalExaminationController);
        IMedicalFindingView CreateNewMedicalFindingView(IMedicalFindingFormController controller, IWaitingRoomController waitingRoomController);
        ISelectPatientView CreateSelectPatientView();
        IDiagnosisChoiceView CreateDiagnosisChoiceView(IMedicalDiagnosisController inController);
        IStatisticsView CreateStatisticsView(Statistics statistic);
        IMedicalHistoryView CreateMedicalHistoryView(Patient patient, List<MedicalFinding> history);
    }
}
