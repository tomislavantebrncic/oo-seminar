﻿using FluentNHibernate.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class MedicalFindingMap : ClassMap<MedicalFinding>
    {
        public MedicalFindingMap()
        {
            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.Date);
            References(p => p.Doctor);
            References(p => p.Patient);
            Map(p => p.Anamnesis);
            Map(p => p.Finding);
            Map(p => p.Status);
            Map(p => p.Therapy);
            References(p => p.MedicalDiagnosis).Not.LazyLoad();
        }
    }
}
