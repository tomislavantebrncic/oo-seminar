﻿using DataAccess.Mappings;
using Model;
using Model.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DoctorRepository : Repository<Doctor, int>, IDoctorRepository 
    {
        public Doctor GetDoctorWithIdAndPassword(string inId, string inPassword)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    IQuery query = session.CreateQuery(
                            "FROM Doctor WHERE EmployeeId = :username AND Password = :password");
                    query.SetString("username", inId);
                    query.SetString("password", inPassword);

                    IList<Doctor> foundDoctors = query.List<Doctor>();

                    if (foundDoctors.Count == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return foundDoctors[0];
                    }
                }
            }
        }
    }
}