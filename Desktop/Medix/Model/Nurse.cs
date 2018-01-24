using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Nurse : Employee
    {

        public Nurse()
        {

        }

        //public Nurse(int inID, string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inEmployeeID, string inPassword) : base(inID, inFirstName, inLastName, inOIB, inDateOfBirth, inEmployeeID, inPassword)
        public Nurse(string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inEmployeeID, string inPassword, WaitingRoom inWaitingRoom) : base(inFirstName, inLastName, inOIB, inDateOfBirth, inEmployeeID, inPassword, inWaitingRoom)
        {
        }
    }
}
