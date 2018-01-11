using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Person : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OIB { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(int inID, string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth) : base(inID)
        {
            FirstName = inFirstName;
            LastName = inLastName;
            OIB = inOIB;
            DateOfBirth = inDateOfBirth;
        }

    }
}
