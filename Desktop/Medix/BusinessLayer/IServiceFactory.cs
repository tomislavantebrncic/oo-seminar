using BaseLib;

namespace BusinessLayer
{
    public interface IServiceFactory
    {
        IAuthenticationService CreateAuthenticationService(IUnitOfWork inUnitOfWork);
        IWaitingRoomService CreateWaitingRoomService(IUnitOfWork inUnitOfWork);
        IDoctorService createDoctorService(IUnitOfWork inUnitOfWork);
        IMedicalExaminationService createMedicalExaminationService(IUnitOfWork inUnitOfWork);
        IMedicalFindingService createMedicalFindingService(IUnitOfWork inUnitOfWork);
        IPatientService createPatientService(IUnitOfWork inUnitOfWork);
        IDiagnosisService createMedicalDiagnosisService(IUnitOfWork inUnitOfWork);
        IStatisticsService createStatisticsService(IUnitOfWork inUnitOfWork);
        IExaminationTypeService CreateExaminationTypeService(IUnitOfWork inUnitOfWork);
    }
}
