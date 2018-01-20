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

        private void buttonExamine_Click(object sender, EventArgs e)
        {
            var row = dataGridViewWaitingRoom.SelectedRows[0];

            var cell = row.Cells[0];

            var patient = (Patient)cell.Value;

            labelPatientId.Text = patient.PatientID;
            labelPatientName.Text = patient.ToString();
            labelPatientDate.Text = patient.DateOfBirth.ToShortDateString();

            _mainController.Examine(patient);
        }

        public void Update(List<MedicalExamination> inListExaminations)
        {
            _listExaminations = inListExaminations;

            UpdateWaitingRoom();
        }

    }
}
