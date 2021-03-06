﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Repositories;

namespace BusinessLayer
{
    public class DoctorService : Service<Doctor, int>, IDoctorService   
    {
        public DoctorService(IDoctorRepository inRepository)
        {
            repository = inRepository;
        }

        public Doctor GetByEmployeeId(string employeeId)
        {
            return ((IDoctorRepository)repository).GetByEmployeeId(employeeId);
        }

        public Doctor GetDoctorWithIdAndPassword(string id, string password)
        {
            return ((IDoctorRepository)repository).GetByUsernameAndPassword(id, password);
        }
    }
}
