using BaseLib;
using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class MainFormController : IMainFormController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IRepositoryFactory _repositoryFactory = null;
        private Doctor _doctor = null;

        public MainFormController(IWindowFormsFactory inFormsFactory, IRepositoryFactory inRepositoryFactory)
        {
            _repositoryFactory = inRepositoryFactory;
            _formsFactory = inFormsFactory;
        }

        public bool CheckAuthentication(string inId, string inPassword)
        {
            var doctorRepository = _repositoryFactory.CreateDoctorRepository();

            _doctor = doctorRepository.GetDoctorWithIdAndPassword(inId, inPassword);

            return (_doctor != null) ? true : false;
        }

        public void ShowWaitingRoom()
        {
            var wrController = new WaitingRoomController(_doctor, _formsFactory, _repositoryFactory);

            var newFrm = _formsFactory.CreateWaitingRoomView();

            wrController.ViewWaitingRoom(newFrm, this);
        }

        public void Examine(Patient inPatient)
        {
            //MessageBox.Show(inPatient.ToString());
        }
    }
}
