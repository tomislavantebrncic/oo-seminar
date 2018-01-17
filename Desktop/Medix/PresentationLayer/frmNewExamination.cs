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
    public partial class frmNewExamination : Form, INewExaminationView
    {
        private IMainFormController _mainController = null;

        public frmNewExamination()
        {
            InitializeComponent();
        }

        public void ShowModaless(Patient patient, IMainFormController inMainController)
        {
            _mainController = inMainController;
            patientNamelabel.Text = patient.FirstName + " " + patient.LastName;
            patientBirthDateLabel.Text = patient.DateOfBirth.ToString();
            patientIdLabel.Text = patient.OIB;

            this.Show();
        }
    }
}
