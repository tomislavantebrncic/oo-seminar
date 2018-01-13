using Controller;
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
    public partial class frmMainWindow : Form
    {
        private readonly MainFormController _controller;
        private readonly WindowFormsFactory _formsFactory = new WindowFormsFactory();

        public frmMainWindow(MainFormController inMainController)
        {
            _controller = inMainController;

            InitializeComponent();
        }

        private void waitingRoomButton_Click(object sender, EventArgs e)
        {
            _controller.ShowWaitingRoom();
        }
    }
}
