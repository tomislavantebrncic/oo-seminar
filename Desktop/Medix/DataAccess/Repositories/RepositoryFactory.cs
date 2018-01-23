using BaseLib;
using DataAccess.Repositories;
using Model.Repositories;
using Model.RepositoryInterfaces;

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

        public IDiagnosisRepository CreateDiagnosisRepository()
        {
            return new DiagnosisRepository();
        }
    }
}
