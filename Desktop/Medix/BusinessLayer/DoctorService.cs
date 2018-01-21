using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Repositories;

namespace BusinessLayer
{
    class DoctorService : Service<Doctor, int>, IDoctorService   
    {
        IDoctorRepository repository { get; set; }

        public Doctor GetDoctorWithIdAndPassword(string id, string password)
        {
            return repository.GetDoctorWithIdAndPassword(id, password);
        }
    }
}
