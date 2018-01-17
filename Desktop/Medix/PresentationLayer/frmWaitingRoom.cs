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
            patientNameLabel.Text = inDoctor.FirstName;
            UpdateWaitingRoom();

            this.Show();
        }

        private void UpdateWaitingRoom()
        {
            

            ListViewItem lvt1 = new ListViewItem("id");
            lvt1.SubItems.Add("patient");
            lvt1.SubItems.Add("time");

            waitingRoomListView.Items.Add(lvt1);

            for (int i = 0; i < _listExaminations.Count(); i++)
            {
                MedicalExamination ex = _listExaminations[i];

                string id = ex.Patient.PatientID;
                string patient = ex.Patient.FirstName + " " + ex.Patient.LastName;
                string time = ex.ExaminationDate.ToShortDateString() + " " + ex.ExaminationDate.ToLongTimeString();

                ListViewItem lvt = new ListViewItem(id);
                lvt.SubItems.Add(patient);
                lvt.SubItems.Add(time);

                waitingRoomListView.Items.Add(lvt);
            }
        }

        private void waitingRoomListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var firstSelectedItem = waitingRoomListView.SelectedItems[0];

            _mainController.CreateNewExamination(firstSelectedItem.Name);
        }
    }
}
