using BaseLib;
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

        public IWaitingRoomView CreateWaitingRoomView()
        {
            var newFrm = new frmWaitingRoom();

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
    }
}
