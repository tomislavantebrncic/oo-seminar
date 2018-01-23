using DataAccess.Mappings;
using Model;
using Model.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class DiagnosisRepository : Repository<MedicalDiagnosis, int>, IDiagnosisRepository
    {
    }
}
