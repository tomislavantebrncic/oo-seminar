using FluentNHibernate.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    class MedicalFindingDescriptionMap : ClassMap<MedicalFindingDescription>
    {
        public MedicalFindingDescriptionMap()
        {
            Id(p => p.Id).GeneratedBy.Native();
            References(p => p.Anamnesis);
            References(p => p.Finding);
            References(p => p.Status);
            References(p => p.Therapy);
        }
    }
}
