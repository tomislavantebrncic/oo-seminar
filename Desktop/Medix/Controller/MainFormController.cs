using BaseLib;
using BusinessLayer;
using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UoW;

namespace Controller
{
    public class MainFormController : BaseController, IMainFormController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IServiceFactory _serviceFactory = null;

        public MainFormController(IWindowFormsFactory inFormsFactory, IServiceFactory inServiceFactory) : base()
        {
            _serviceFactory = inServiceFactory;
            _formsFactory = inFormsFactory;
        }

        public bool CheckAuthentication(string inId, string inPassword)
        {
            var authenticationService = _serviceFactory.CreateAuthenticationService(_unitOfWork);

            return authenticationService.Authenticate(inId, inPassword);
        }

        public void Logout()
        {
            var authenticationService = _serviceFactory.CreateAuthenticationService(_unitOfWork);

            authenticationService.Logout();
        }

        public void ShowWaitingRoom()
        {
            //_unitOfWork.BeginTransaction();
            var wrController = new WaitingRoomController(_formsFactory, _serviceFactory);

            var newFrm = _formsFactory.CreateWaitingRoomView(this);

            wrController.ViewWaitingRoom(newFrm);
        }
    }
}
