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
    public partial class frmDiagnosisChoice : Form, IDiagnosisChoiceView
    {
        private readonly IMedicalDiagnosisController _controller;
        private List<MedicalDiagnosis> medicalDiagnosis;

        public frmDiagnosisChoice(IMedicalDiagnosisController inController)
        {
            _controller = inController;
            InitializeComponent();
        }

        public void ShowModales(MedicalDiagnosis diagnosis)
        {
            this.Show();
        }

        public void Update(List<MedicalDiagnosis> diagnosis)
        {
            dataGridView1.DataSource = medicalDiagnosis;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
    }
}
