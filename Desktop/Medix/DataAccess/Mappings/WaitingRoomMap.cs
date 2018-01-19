using FluentNHibernate.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class WaitingRoomMap : ClassMap<WaitingRoom>
    {
        public WaitingRoomMap()
        {
            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.Name);
            HasMany(p => p.Examinations);
        }
    }
}
