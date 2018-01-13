using Controller;
using MemoryDAL;
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

            //MainFormController mainController = new MainFormController(_formsFactory, WaitingRoomRepository.getInstance());
            MainFormController mainController = new MainFormController(_formsFactory, new WaitingRoomRepository());



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PresentationLayer.frmMainWindow(mainController));
        }
    }
}
