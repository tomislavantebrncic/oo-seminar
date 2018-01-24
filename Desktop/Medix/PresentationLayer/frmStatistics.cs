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
            List<StatisticDisplay> display = new List<StatisticDisplay>();

            foreach(var exam in _statistics.examinations)
            {
                display.Add(new StatisticDisplay(exam));
            }
            dataGridView1.DataSource = display;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }

            label4.Text = "Pacijenata: " + _statistics.patientCount;
            label5.Text = "Sredstava: " + _statistics.priceSum.ToString("c2",
                CultureInfo.CreateSpecificCulture("hr-HR"));
        }

        public class StatisticDisplay
        {
            public string name { get; set; }
            public string price { get; set; }

            public StatisticDisplay(MedicalExamination stats)
            {
                this.name = stats.Patient.FirstName + " " + stats.Patient.LastName;
                this.price = stats.ExaminationType.Price.ToString("c2",
                CultureInfo.CreateSpecificCulture("hr-HR"));
            }

        }
    }
}
