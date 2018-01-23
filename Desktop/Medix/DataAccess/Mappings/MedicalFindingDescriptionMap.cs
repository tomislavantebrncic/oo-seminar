using FluentNHibernate.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class MedicalFindingDescriptionMap : ClassMap<MedicalFindingDescription>
    {
        public MedicalFindingDescriptionMap()
        {
            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.Anamnesis);
            Map(p => p.Finding);
            Map(p => p.Status);
            Map(p => p.Therapy);
        }
    }
}
