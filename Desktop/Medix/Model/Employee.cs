using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee : Person
    {
        public string EmployeeID { get; set; }
        public string Password { get; set; }

        public Employee(int inID, string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inEmployeeID, string inPassword) : base(inID, inFirstName, inLastName, inOIB, inDateOfBirth)
        {
            EmployeeID = inEmployeeID;
            Password = inPassword;
        }
    }
}
