using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoggedIn
    {
        private static Employee _employee = null;
        private static WaitingRoom _waitingRoom = null;

        private LoggedIn(Employee inEmployee)
        {
            _employee = inEmployee;
        }

        public static void Initialize(Employee inEmployee)
        {
            if (_employee == null)
            {
                _employee = inEmployee;
                _waitingRoom = inEmployee.WaitingRoom;
            }
        }

        public static Employee GetEmployee()
        {
            return _employee;
        }

        public static WaitingRoom GetWaitingRoom()
        {
            return _waitingRoom;
        }
    }
}
