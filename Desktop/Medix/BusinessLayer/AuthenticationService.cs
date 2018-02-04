using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AuthenticationService : Service<Employee, int>, IAuthenticationService
    {
        public AuthenticationService(IEmployeeRepository inRepository)
        {
            repository = inRepository;
        }

        public bool Authenticate(string inUsername, string inPassword)
        {
            var employee = ((IEmployeeRepository)repository).GetByUsernameAndPassword(inUsername, inPassword);
            if (employee != null)
            {
                LoggedIn.Initialize(employee);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Logout()
        {
            LoggedIn.Logout();
        }
    }
}
