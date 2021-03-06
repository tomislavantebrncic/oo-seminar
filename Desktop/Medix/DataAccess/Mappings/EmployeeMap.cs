﻿using FluentNHibernate.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(p => p.Id).GeneratedBy.Native();
            Map(p => p.FirstName);
            Map(p => p.LastName);
            Map(p => p.OIB);
            Map(p => p.DateOfBirth);
            Map(p => p.EmployeeID);
            Map(p => p.Password);
            References(p => p.WaitingRoom);

            DiscriminateSubClassesOnColumn("Type");
        }
    }
}
