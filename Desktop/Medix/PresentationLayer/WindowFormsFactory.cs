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
        public IMedicalFindingView CreateNewMedicalFindingView()
        {
            throw new NotImplementedException();
        }

        public IWaitingRoomView CreateWaitingRoomView()
        {
            var newFrm = new frmWaitingRoom();

            return newFrm;
        }

        public IAddMedicalExaminationView CreateAddMedicalExaminationView()
        {
            var newFrm = new frmAddMedicalExamination();

            return newFrm;
        }
    }
}
