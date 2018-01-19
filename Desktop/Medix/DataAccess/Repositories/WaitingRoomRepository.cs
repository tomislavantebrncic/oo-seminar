using Model;
using Model.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class WaitingRoomRepository : IWaitingRoomRepository
    {
        private static WaitingRoomRepository _instance;
        private readonly List<MedicalExamination> _listExaminations;

        public WaitingRoomRepository()
        {
            _listExaminations = new List<MedicalExamination>();
        }

        //private WaitingRoomRepository()
        //{
        //    _listExaminations = new List<MedicalExamination>();
        //}

        public static WaitingRoomRepository getInstance()
        {
            return _instance ?? (_instance = new WaitingRoomRepository());
        }

        public List<MedicalExamination> getAllExaminationsInWaitingRoom(string inId)
        {
            
            return _listExaminations;
        }
    }
}
