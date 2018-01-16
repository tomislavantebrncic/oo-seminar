using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IDoctorRepository
    {
        Doctor GetDoctorWithIdAndPassword(string inId, string inPassword);
    }
}
