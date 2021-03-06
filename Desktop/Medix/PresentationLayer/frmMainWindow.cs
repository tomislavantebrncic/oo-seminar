﻿using Controller;
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
    public partial class frmMainWindow : Form
    {
        private readonly MainFormController _controller;
        private readonly WindowFormsFactory _formsFactory = new WindowFormsFactory();

        public frmMainWindow(MainFormController inMainController)
        {
            _controller = inMainController;

            InitializeComponent();
        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Unesite korisničko ime.");

                return;
            }
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Unesite lozinku.");

                return;
            }


            if (_controller.CheckAuthentication(textBoxUsername.Text, textBoxPassword.Text))
            {
                _controller.ShowWaitingRoom();
            }
            else
            {
                MessageBox.Show("Neuspješna autorizacija");

                return;
            }
        }
    }
}
