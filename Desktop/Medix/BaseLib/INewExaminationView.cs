using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface INewExaminationView
    {
        void ShowModaless(Patient inPatient, IMainFormController inMainController);
    }
}
