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
        void AddNewMedicalExamination(IAddMedicalExaminationView inForm);
        void ShowSelectPatient();
        void UpdateInfo(Patient inPatient);
        void Close();
    }
}
