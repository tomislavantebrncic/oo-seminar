﻿using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class WaitingRoomService : Service<WaitingRoom, int>, IWaitingRoomService
    {
        public WaitingRoomService(IWaitingRoomRepository inRepository) : base(inRepository)
        {
        }
    }
}
