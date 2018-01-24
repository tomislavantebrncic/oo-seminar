using BaseLib;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmStatistics : Form, IStatisticsView
    {
        Statistics _statistics;

        public frmStatistics(Statistics statistics)
        {
            _statistics = statistics;
            InitializeComponent();
        }

        public void ShowModaless()
        {
            label1.Text = _statistics.doctor.FirstName + " " + _statistics.doctor.LastName;
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ShowStatistics();
            this.Show();
        }

        public void ShowStatistics()
        {

            dataGridView1.DataSource = _statistics.examinations;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }

            label4.Text = "Pacijenata: " + _statistics.patientCount;
            label5.Text = "Sredstava: " + _statistics.priceSum.ToString("c2",
                CultureInfo.CreateSpecificCulture("hr-HR"));
        }
    }
}
