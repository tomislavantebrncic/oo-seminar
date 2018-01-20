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
    public partial class frmSelectPatient : Form, ISelectPatientView
    {
        private IPatientController _patientController = null;

        public frmSelectPatient()
        {
            InitializeComponent();
        }

        public void ShowModaless(IPatientController inPatientController)
        {
            _patientController = inPatientController;

            this.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listViewPatients.Clear();
            IList<Patient> patients = null;

            if (textBoxLastName.Text != "")
            {
                patients = _patientController.SearchPatients(textBoxLastName.Text);
            }
            else
            {
                MessageBox.Show("Unesite podatke za pretragu.");
            }
            
            foreach (Patient patient in patients)
            {
                MessageBox.Show(patient.ToString());
                ListViewItem item = new ListViewItem();
                item.Text = patient.PatientID + ", " + patient.ToString();
                item.Tag = patient;
                listViewPatients.Items.Add(item);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            _patientController.UpdateAddMedicalExaminationPatient((Patient)listViewPatients.SelectedItems[0].Tag);
        }

        private void listViewPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = listViewPatients.SelectedItems.Count == 1;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}