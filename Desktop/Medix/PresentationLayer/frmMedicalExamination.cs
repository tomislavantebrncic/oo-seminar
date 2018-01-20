﻿using BaseLib;
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
        //private MedicalExamination examination;

        public frmMedicalExamination()
        {
            InitializeComponent();
        }

        public frmMedicalExamination(MainFormController controller, MedicalFindingFormController medicalController)
        {
            _controller = medicalController;
            _mainController = controller;
            InitializeComponent();
        }

        public void ShowModaless(Patient patient)
        {
            patientNamelabel.Text = patient.FirstName + " " + patient.LastName;
            patientBirthDateLabel.Text = patient.DateOfBirth.ToString();
            patientIdLabel.Text = patient.OIB;

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicalFindingDescription medicalFindingDescription =
                new MedicalFindingDescription(textBox1.Text, textBox4.Text,
                    textBox2.Text, textBox3.Text);
            MedicalFinding medicalFinding = new MedicalFinding(DateTime.Now,
                //treba prenjeti cijeli examination, doktora i pacijenta iz njega
                new Doctor(), new Patient(), medicalFindingDescription,
                new MedicalDiagnosis("novo", "novo")
                );
            //dijagnoza je stavljena random, treba dodat.
            //_controller.
        }
    }
}
