using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Doctor : Employee
    {
        public virtual WaitingRoom WaitingRoom { get; set; }

        public Doctor()
        {

        }

        public Doctor(int inID, string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inEmployeeID, string inPassword) : base(inFirstName, inLastName, inOIB, inDateOfBirth, inEmployeeID, inPassword)
        {

        }
        public Doctor(string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inEmployeeID, string inPassword, WaitingRoom inWaitingRoom) : base(inFirstName, inLastName, inOIB, inDateOfBirth, inEmployeeID, inPassword)
        {
            WaitingRoom = inWaitingRoom;
        }
    }
}
