using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee : Person
    {
        public virtual string EmployeeID { get; set; }
        public virtual string Password { get; set; }

        public Employee() : base()
        {

        }

        //public Employee(int inID, string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inEmployeeID, string inPassword) : base(inID, inFirstName, inLastName, inOIB, inDateOfBirth)
        public Employee(string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth, string inEmployeeID, string inPassword) : base(inFirstName, inLastName, inOIB, inDateOfBirth)
        {
            EmployeeID = inEmployeeID;
            Password = inPassword;
        }
    }
}
