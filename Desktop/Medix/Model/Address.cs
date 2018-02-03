using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _zipcode;

        public virtual string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public virtual string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public virtual string Zipcode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }
    }
}
