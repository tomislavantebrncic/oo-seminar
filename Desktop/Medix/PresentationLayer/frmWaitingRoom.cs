using BaseLib;
using Model;
using System;
using System.Collections.Generic;
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

        public void ShowModaless(string inEmployeeName, string inWaitingRoomName, IMainFormController inMainController, IWaitingRoomController inWaitingRoomController, List<MedicalExamination> inListExaminations)
        {
            _mainController = inMainController;
            _waitingRoomController = inWaitingRoomController;
            _listExaminations = inListExaminations;

            UpdateTitle(inEmployeeName, inWaitingRoomName);

            UpdateWaitingRoom();

            this.Show();
        }

        private void UpdateTitle(string inEmployeeName, string inWaitingRoomName)
        {
            labelEmployee.Text = inEmployeeName;
            labelWaitingRoom.Text = inWaitingRoomName;
        }

        private void UpdateWaitingRoom()
        {
            List<DataRow> rows = new List<DataRow>();

            foreach(var exm in _listExaminations)
            {
                rows.Add(new DataRow(exm));
            }


            dataGridViewWaitingRoom.DataSource = rows;

            foreach (DataGridViewRow row in dataGridViewWaitingRoom.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private class DataRow
        {
            public string time { get; set; }
            public string name { get; set; }
            public string tip { get; set; }

            public DataRow(MedicalExamination exm)
            {
                time = exm.ExaminationDate.ToString("dd-MM-yyyy hh:mm");
                name = exm.Patient.FirstName + " " + exm.Patient.LastName;
                tip = exm.ExaminationType.Name;
            }
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

            labelPatientId.Text = examination.Patient.PatientID;
            labelPatientName.Text = examination.Patient.ToString();
            labelPatientDate.Text = examination.Patient.DateOfBirth.ToShortDateString();
            _waitingRoomController.SetPatient(examination.Patient);
            _waitingRoomController.Examine(examination);
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            _waitingRoomController.ShowStatistics();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            _waitingRoomController.ShowHistory();
        }

        private void frmWaitingRoom_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _waitingRoomController.Close();
        }
    }
}
