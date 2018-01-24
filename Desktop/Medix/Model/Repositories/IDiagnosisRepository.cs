using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.RepositoryInterfaces
{
    public interface IDiagnosisRepository : IRepository<MedicalDiagnosis, int>
    {
        List<MedicalDiagnosis> FindByName(string name);
    }
}
