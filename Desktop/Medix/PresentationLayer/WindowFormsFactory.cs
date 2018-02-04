using BaseLib;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class WindowFormsFactory : IWindowFormsFactory
    {
        public IMedicalFindingView CreateNewMedicalFindingView(IMedicalFindingFormController controller, IWaitingRoomController waitingRoomController)
        {
            var newFrm = new frmMedicalExamination(controller, waitingRoomController);
            return newFrm;
        }

        public IWaitingRoomView CreateWaitingRoomView(IMainFormController inMainFormController)
        {
            var newFrm = new frmWaitingRoom(inMainFormController);

            return newFrm;
        }

        public IAddMedicalExaminationView CreateAddMedicalExaminationView(IMedicalExaminationController inMedicalExaminationController)
        {
            var newFrm = new frmAddMedicalExamination(inMedicalExaminationController);

            return newFrm;
        }

        public ISelectPatientView CreateSelectPatientView()
        {
            var newFrm = new frmSelectPatient();

            return newFrm;
        }

        public IDiagnosisChoiceView CreateDiagnosisChoiceView(IMedicalDiagnosisController inController)
        {
            var newFrm = new frmDiagnosisChoice(inController);
            return newFrm;
        }

        public IStatisticsView CreateStatisticsView(Statistics statistics)
        {
            var newFrm = new frmStatistics(statistics);
            return newFrm;
        }

        public IMedicalHistoryView CreateMedicalHistoryView(Patient patient, List<MedicalFinding> history)
        {
            var newFrm = new frmMedicalHistory(patient, history);
            return newFrm;
        }
    }
}
