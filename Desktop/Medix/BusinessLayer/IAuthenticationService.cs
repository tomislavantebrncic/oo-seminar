using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IAuthenticationService :IService<Employee, int>
    {
        bool Authenticate(string inUsername, string inPassword);
    }
}
