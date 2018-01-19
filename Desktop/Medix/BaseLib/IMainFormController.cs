using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IMainFormController
    {
        void CreateNewExamination(string name);
        void AddExamination();
        void Examine(Patient inPatient);

    }
}
