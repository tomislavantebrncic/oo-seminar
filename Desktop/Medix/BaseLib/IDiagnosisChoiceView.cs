using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
     public interface IDiagnosisChoiceView
    {
        void ShowModales(MedicalDiagnosis diagnosis);
        void Update(List<MedicalDiagnosis> diagnosis);
    }
}
