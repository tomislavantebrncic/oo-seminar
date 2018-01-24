using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ExaminationTypeService : Service<ExaminationType, int>, IExaminationTypeService
    {
        public ExaminationTypeService(IExaminationTypeRepository inExaminationTypeRepository) : base(inExaminationTypeRepository)
        {

        }
    }
}
