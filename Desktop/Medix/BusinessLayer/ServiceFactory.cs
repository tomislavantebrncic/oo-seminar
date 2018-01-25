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

        public IDoctorService createDoctorService(IUnitOfWork inUnitOfWork)
        {
            return new DoctorService(factory.CreateDoctorRepository(inUnitOfWork));
        }

        public IDiagnosisService createMedicalDiagnosisService(IUnitOfWork inUnitOfWork)
        {
            return new DiagnosisService(factory.CreateDiagnosisRepository(inUnitOfWork));
        }

        public IMedicalExaminationService createMedicalExaminationService(IUnitOfWork inUnitOfWork)
        {
            return new MedicalExaminationService(factory.CreateMedicalExaminationRepository(inUnitOfWork));
        }

        public IMedicalFindingService createMedicalFindingService(IUnitOfWork inUnitOfWork)
        {
            return new MedicalFindingService(factory.CreateMedicalFindingRepository(inUnitOfWork));
        }

        public IPatientService createPatientService(IUnitOfWork inUnitOfWork)
        {
            return new PatientService(factory.CreatePatientRepository(inUnitOfWork));
        }

        public IStatisticsService createStatisticsService(IUnitOfWork inUnitOfWork)
        {
            return new StatisticsService(factory.CreateMedicalExaminationRepository(inUnitOfWork));
        }

        public IExaminationTypeService CreateExaminationTypeService(IUnitOfWork inUnitOfWork)
        {
            return new ExaminationTypeService(factory.CreateExaminationTypeRepository(inUnitOfWork));
        }
    }
}
