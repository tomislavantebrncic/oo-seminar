using FluentNHibernate.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class MedicalExaminationMap : ClassMap<MedicalExamination>
    {
        public MedicalExaminationMap()
        {
            Id(p => p.Id)
                .GeneratedBy.Native();
            Map(p => p.ExaminationDate);
            Map(p => p.Examined);
            References(p => p.Doctor);

        }
    }
}
