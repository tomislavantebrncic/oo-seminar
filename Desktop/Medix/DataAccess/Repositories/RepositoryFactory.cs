using BaseLib;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IDoctorRepository CreateDoctorRepository()
        {
            return new DoctorRepository();
        }

        public IMedicalExaminationRepository CreateMedicalExaminationRepository()
        {
            return new MedicalExaminationRepository();
        }

        public IPatientRepository CreatePatientRepository()
        {
            return new PatientRepository();
        }

        public IMedicalFindingRepository CreateMedicalFindingRepository()
        {
            return new MedicalFindingRepository();
        }
    }
}
