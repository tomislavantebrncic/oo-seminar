using Model;
using Model.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DiagnosisService : Service<MedicalDiagnosis, int>, IDiagnosisService
    {
        public DiagnosisService(IDiagnosisRepository inRepository)
        {
            repository = inRepository;
        }

        public List<MedicalDiagnosis> FindDiagnosisByName(string text)
        {
            return ((IDiagnosisRepository)repository).FindByName(text);
        }
    }
}
