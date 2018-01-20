using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IMedicalExaminationController
    {
        void AddNewMedicalExamination(IAddMedicalExaminationView inForm, Doctor inDoctor);
        void ShowSelectPatient();
    }
}
