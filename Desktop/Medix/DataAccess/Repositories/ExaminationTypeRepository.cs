using BaseLib;
using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ExaminationTypeRepository : Repository<ExaminationType, int>, IExaminationTypeRepository
    {
        public ExaminationTypeRepository(IUnitOfWork inUnitOfWork) : base(inUnitOfWork)
        {
        }
    }
}
