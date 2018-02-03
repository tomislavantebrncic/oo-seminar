using Model.Repositories;
using Model.RepositoryInterfaces;

namespace BaseLib
{
    public interface IRepositoryFactory
    {
        IEmployeeRepository CreateEmployeeRepository(IUnitOfWork inUnitOfWork);
        IPatientRepository CreatePatientRepository(IUnitOfWork inUnitOfWork);
        IDoctorRepository CreateDoctorRepository(IUnitOfWork inUnitOfWork);
        IMedicalExaminationRepository CreateMedicalExaminationRepository(IUnitOfWork inUnitOfWork);
        IMedicalFindingRepository CreateMedicalFindingRepository(IUnitOfWork inUnitOfWork);
        IDiagnosisRepository CreateDiagnosisRepository(IUnitOfWork inUnitOfWork);
        IExaminationTypeRepository CreateExaminationTypeRepository(IUnitOfWork inUnitOfWork);
        IWaitingRoomRepository CreateWaitingRoomRepository(IUnitOfWork inUnitOfWork);
    }
}
