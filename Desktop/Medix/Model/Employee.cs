using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee : Person
    {
        private string _employeeID;
        private string _password;
        private WaitingRoom _waitingRoom;

        public virtual string EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        public virtual string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public virtual WaitingRoom WaitingRoom
        {
            get { return _waitingRoom; }
            set { _waitingRoom = value; }
        }

        public Employee() : base()
        {

        }

        //public Employee(int inID, string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inEmployeeID, string inPassword) : base(inID, inFirstName, inLastName, inOIB, inDateOfBirth)
        public Employee(string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inEmployeeID, string inPassword, WaitingRoom inWaitingRoom) : base(inFirstName, inLastName, inOIB, inDateOfBirth)
        {
            EmployeeID = inEmployeeID;
            Password = inPassword;
            WaitingRoom = inWaitingRoom;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
