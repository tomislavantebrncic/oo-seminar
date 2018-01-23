using FluentNHibernate.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class MedicalDiagnosisMap : ClassMap<MedicalDiagnosis>
    {
        public MedicalDiagnosisMap()
        {
            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.NameHRV);
            Map(p => p.NameLAT);
        }
    }
}
