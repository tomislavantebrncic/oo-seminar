using BaseLib;
using Controller;
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
    public partial class frmMedicalExamination : Form, IMedicalFindingView
    {
        private IMainFormController _mainController = null;
        private IMedicalFindingFormController _controller = null;
        private IWaitingRoomController _waitingRoomController = null;
        private MedicalExamination examination = null;

        private MedicalFinding finding;
        
        public frmMedicalExamination(IMedicalFindingFormController inController, IWaitingRoomController waitingRoomController)
        {
            _controller = inController;
            _waitingRoomController = waitingRoomController;
            InitializeComponent();
        }

        public frmMedicalExamination(MainFormController controller, MedicalFindingFormController medicalController, IWaitingRoomController inWaitingRoomController)
        {
            _controller = medicalController;
            _mainController = controller;
            _waitingRoomController = inWaitingRoomController;
            InitializeComponent();
        }

        public void ShowModaless(MedicalExamination inExamination)
        {
            examination = inExamination;
            patientNamelabel.Text = examination.Patient.FirstName + " " + examination.Patient.LastName;
            patientBirthDateLabel.Text = examination.Patient.DateOfBirth.ToString();
            patientIdLabel.Text = examination.Patient.OIB;

            finding = new MedicalFinding(DateTime.Now,
                examination.Doctor, examination.Patient, new MedicalFindingDescription(),
                new MedicalDiagnosis()
                );

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicalFindingDescription medicalFindingDescription =
                new MedicalFindingDescription(textBox1.Text, textBox4.Text,
                    textBox2.Text, textBox3.Text);
            finding.FindingDesc = medicalFindingDescription;
            _controller.saveFinding(finding);
            _waitingRoomController.SetExamined(examination);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             _controller.ChooseDiagnosis(finding);
        }
    }
}
