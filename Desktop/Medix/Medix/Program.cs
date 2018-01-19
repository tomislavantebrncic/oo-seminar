﻿using Controller;
using DataAccess;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medix
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowFormsFactory _formsFactory = new WindowFormsFactory();
            RepositoryFactory _repositoryFactory = new RepositoryFactory();

            MainFormController mainController = new MainFormController(_formsFactory, _repositoryFactory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PresentationLayer.frmMainWindow(mainController));
        }
    }
}
