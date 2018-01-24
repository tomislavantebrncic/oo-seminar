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
    public partial class frmAddMedicalExamination : Form, IAddMedicalExaminationView
    {
        private IMedicalExaminationController _medicalExaminationController = null;

        public frmAddMedicalExamination(IMedicalExaminationController inMedicalExaminationController)
        {
            _medicalExaminationController = inMedicalExaminationController;

            InitializeComponent();
        }

        private void FillList(IList<ExaminationType> inTypes)
        {
            comboBoxExaminationType.DataSource = inTypes;
        }

        public bool ShowViewModal(IList<ExaminationType> inTypes)
        {
            FillList(inTypes);

            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }

        public string PatientId => textBoxId.Text;
        public string PatientFirstName => textBoxFirstName.Text;
        public string PatientLastName => textBoxLastName.Text;
        public string PatientOIB => textBoxOIB.Text;
        public string PatientDateOfBirth => textBoxDateOfBirth.Text;
        public ExaminationType ExaminationType => (ExaminationType)comboBoxExaminationType.SelectedItem;

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            _medicalExaminationController.ShowSelectPatient();
        }

        public void UpdateInfo(Patient inPatient)
        {
            textBoxId.Text = inPatient.PatientID;
            textBoxFirstName.Text = inPatient.FirstName;
            textBoxLastName.Text = inPatient.LastName;
            textBoxOIB.Text = inPatient.OIB;
            textBoxDateOfBirth.Text = inPatient.DateOfBirth.ToString("dd.mm.yyyy");
        }

        private void comboBoxExaminationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
