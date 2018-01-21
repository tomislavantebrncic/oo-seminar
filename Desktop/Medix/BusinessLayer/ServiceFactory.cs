using BaseLib;
using DataAccess;

namespace BusinessLayer
{
    public class ServiceFactory : IServiceFactory
    {
        IRepositoryFactory factory;

        public ServiceFactory(RepositoryFactory inFactory) {
            factory = inFactory;
        }

        public IDoctorService createDoctorService()
        {
            return new DoctorService(factory.CreateDoctorRepository());
        }

        public IMedicalExaminationService createMedicalExaminationService()
        {
            return new MedicalExaminationService(factory.CreateMedicalExaminationRepository());
        }

        public IMedicalFindingService createMedicalFindingService()
        {
            return new MedicalFindingService(factory.CreateMedicalFindingRepository());
        }

        public IPatientService createPatientService()
        {
            return new PatientService(factory.CreatePatientRepository());
        }
    }
}
