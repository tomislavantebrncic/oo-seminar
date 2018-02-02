using FluentNHibernate.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class NurseMap : SubclassMap<Nurse>
    {
        public NurseMap()
        {
            DiscriminatorValue("nurse");
        }
    }
}
