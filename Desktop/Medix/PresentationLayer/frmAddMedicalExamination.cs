using BaseLib;
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

        public bool ShowViewModal()
        {
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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            _medicalExaminationController.ShowSelectPatient();
        }
    }
}
