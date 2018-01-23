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
        private List<MedicalDiagnosis> _diagnosisList;

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
            _diagnosisList = diagnosis;
            dataGridView1.DataSource = diagnosis;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        public void FindDiagnosisByName(string name)
        {
            Update(_controller.FindDiagnosisByName(name));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindDiagnosisByName(textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _controller.ChooseDiagnosis(_diagnosisList[e.RowIndex]);
            this.Close();
        }
    }
}
