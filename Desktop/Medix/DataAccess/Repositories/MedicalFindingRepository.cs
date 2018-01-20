using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Mappings;
using Model;
using Model.Repositories;
using NHibernate;

namespace DataAccess
{
    class MedicalFindingRepository : Repository<MedicalFinding,int>, IMedicalFindingRepository
    {
        private static MedicalFindingRepository _instance;
        // private readonly List<MedicalExamination> _listExaminations;

        public MedicalFindingRepository()
        {
            //_listExaminations = new List<MedicalExamination>();
        }

        public static MedicalFindingRepository getInstance()
        {
            return _instance ?? (_instance = new MedicalFindingRepository());
        }

        public void Save(MedicalFinding finding)
        {
            throw new NotImplementedException();
        }
    }
}
