using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IMainFormController : IBaseController
    {
        bool CheckAuthentication(string inId, string inPassword);
        void ShowWaitingRoom();
        void Logout();
    }
}
