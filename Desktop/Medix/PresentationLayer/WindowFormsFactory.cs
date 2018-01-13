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
        public IWaitingRoomView CreateWaitingRoomView()
        {
            var newFrm = new frmWaitingRoom();

            return newFrm;
        }
    }
}
