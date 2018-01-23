using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IMedicalDiagnosisController
    {
        void ViewDiagnosisChoice(IDiagnosisChoiceView inForm);
        List<MedicalDiagnosis> FindDiagnosisByName(string name);
        MedicalDiagnosis ChooseDiagnosis(MedicalDiagnosis diagnosis);
    }
}
