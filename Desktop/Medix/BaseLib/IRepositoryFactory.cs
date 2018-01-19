using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IRepositoryFactory
    {
        IPatientRepository CreatePatientRepository();
        IDoctorRepository CreateDoctorRepository();
        IMedicalExaminationRepository CreateMedicalExaminationRepository();
    }
}
