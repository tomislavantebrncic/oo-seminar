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
        private IWaitingRoomController _waitingRoomController = null;

        public frmWaitingRoom()
        {
            InitializeComponent();
        }

        public void ShowModaless(Doctor inDoctor, IMainFormController inMainController, IWaitingRoomController inWaitingRoomController, List<MedicalExamination> inListExaminations)
        {
            _mainController = inMainController;
            _waitingRoomController = inWaitingRoomController;
            _listExaminations = inListExaminations;

            UpdateWaitingRoom();

            this.Show();
        }

        private void UpdateWaitingRoom()
        {
            dataGridViewWaitingRoom.DataSource = _listExaminations;
        }

        private void buttonNewExamination_Click(object sender, EventArgs e)
        {
            _waitingRoomController.AddExamination();
        }

        public void Update(List<MedicalExamination> inListExaminations)
        {
            _listExaminations = inListExaminations;

            UpdateWaitingRoom();
        }

        private void dataGridViewWaitingRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var examination = _listExaminations[e.RowIndex];
            _mainController.Examine(examination);
        }
    }
}
