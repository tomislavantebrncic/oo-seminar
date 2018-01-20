﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IWaitingRoomController
    {
        void ViewWaitingRoom(IWaitingRoomView inForm, IMainFormController mainController);
        void AddExamination();

    }
}
