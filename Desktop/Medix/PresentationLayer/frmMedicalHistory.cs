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
    public partial class frmMedicalHistory : Form, IMedicalHistoryView
    {
        Patient patient;
        List<MedicalFinding> history;

        public frmMedicalHistory(Patient patient, List<MedicalFinding> history)
        {
            this.patient = patient;
            this.history = history;
            InitializeComponent();
        }

        public void ShowModaless()
        {
            label1.Text = patient.FirstName + " " + patient.LastName;
            label2.Text = patient.DateOfBirth.ToString("dd/MM/yyyy");

            dataGridView1.DataSource = history;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }

            this.Show();
        }
    }
}
