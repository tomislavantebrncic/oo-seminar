using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryDAL
{
    public class WaitingRoomRepository : IWaitingRoomRepository
    {
        private static WaitingRoomRepository _instance;
        private readonly List<MedicalExamination> _listExaminations;

        public WaitingRoomRepository()
        {

        }

        //private WaitingRoomRepository()
        //{
        //    _listExaminations = new List<MedicalExamination>();
        //}

        public static WaitingRoomRepository getInstance()
        {
            return _instance ?? (_instance = new WaitingRoomRepository());
        }

        public List<MedicalExamination> getAllExaminations()
        {
            return _listExaminations;
        }
    }
}
