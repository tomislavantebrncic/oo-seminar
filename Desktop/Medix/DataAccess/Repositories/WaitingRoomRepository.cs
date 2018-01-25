using BaseLib;
using DataAccess.Mappings;
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
    public class WaitingRoomRepository : Repository<WaitingRoom, int>, IWaitingRoomRepository
    {
        public WaitingRoomRepository(IUnitOfWork inUnitOfWork) : base(inUnitOfWork)
        {
        }
    }
}
