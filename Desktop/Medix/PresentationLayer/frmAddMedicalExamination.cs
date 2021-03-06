﻿using BaseLib;
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
        public string Address => textBoxAddress.Text;
        public string City => textBoxCity.Text;
        public string ZipCode => textBoxZipCode.Text;
        public ExaminationType ExaminationType => (ExaminationType)comboBoxExaminationType.SelectedItem;
        public bool Emergency => checkBoxEmergency.Checked;

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string msg = InputIncorrect();
            if (msg != null)
            {
                MessageBox.Show(msg);
                return;
            }
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
            textBoxAddress.Text = inPatient.Address.Street;
            textBoxCity.Text = inPatient.Address.City;
            textBoxZipCode.Text = inPatient.Address.Zipcode;
        }

        private void comboBoxExaminationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string InputIncorrect()
        {
            if (textBoxId.Text == "")
            {
                return "Unesite identifikacijski broj pacijenta.";
            }
            if (textBoxFirstName.Text == "")
            {
                return "Unesite ime pacijenta.";
            }
            if (textBoxLastName.Text == "")
            {
                return "Unesite prezime pacijenta.";
            }
            if (textBoxOIB.Text == "")
            {
                return "Unesite OIB pacijenta.";
            }
            if (textBoxDateOfBirth.Text == "")
            {
                return "Unesite datum rođenja pacijenta.";
            }
            if (textBoxAddress.Text == "")
            {
                return "Unesite adresu.";
            }
            if (textBoxCity.Text == "")
            {
                return "Unesite grad.";
            }
            if (textBoxZipCode.Text == "")
            {
                return "Unesite poštanski broj.";
            }
            return null;
        }

        private void frmAddMedicalExamination_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _medicalExaminationController.Close();
        }

        private void checkBoxEmergency_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxReference.Checked = !checkBoxEmergency.Checked;
        }

        private void checkBoxReference_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxEmergency.Checked = !checkBoxReference.Checked;
        }
    }
}
