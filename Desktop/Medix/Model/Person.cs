using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Person : Entity<int>
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string OIB { get; set; }
        public virtual DateTime DateOfBirth { get; set; }

        public Person()
        {

        }

        //public Person(int inID, string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth) : base(inID)
        public Person(string inFirstName, string inLastName, string inOIB, DateTime inDateOfBirth) : base()
        {
            FirstName = inFirstName;
            LastName = inLastName;
            OIB = inOIB;
            DateOfBirth = inDateOfBirth;
        }

    }
}
