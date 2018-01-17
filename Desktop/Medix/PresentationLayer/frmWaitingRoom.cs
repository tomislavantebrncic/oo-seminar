using BaseLib;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmWaitingRoom : Form, IWaitingRoomView
    {
        private List<MedicalExamination> _listExaminations = null;
        private IMainFormController _mainController = null;

        public frmWaitingRoom()
        {
            InitializeComponent();
        }

        public void ShowModaless(Doctor inDoctor, IMainFormController inMainController, List<MedicalExamination> inListExaminations)
        {
            _mainController = inMainController;
            _listExaminations = inListExaminations;

            UpdateWaitingRoom();

            this.Show();
        }

        private void UpdateWaitingRoom()
        {
            dataGridViewWaitingRoom.DataSource = _listExaminations;
        }

        private void waitingRoomListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var firstSelectedItem = waitingRoomListView.SelectedItems[0];

            _mainController.CreateNewExamination(firstSelectedItem.Name);
        }
    }
}
