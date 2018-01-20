using FluentNHibernate.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class PatientMap : ClassMap<Patient>
    {
        public PatientMap()
        {
            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.FirstName);
            Map(p => p.LastName);
            Map(p => p.OIB);
            Map(p => p.PatientID);
            Map(p => p.DateOfBirth);
            HasMany(p => p.MedicalHistory);
        }
    }
}
