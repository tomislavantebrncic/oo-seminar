using FluentNHibernate.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class ExaminationTypeMap : ClassMap<ExaminationType>
    {
        public ExaminationTypeMap()
        {
            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.Name);
            Map(p => p.Price);
        }
    }
}
