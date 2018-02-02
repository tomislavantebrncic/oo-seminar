using BaseLib;
using DataAccess.Repositories;
using Model.Repositories;
using Model.RepositoryInterfaces;

namespace DataAccess
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IDoctorRepository CreateDoctorRepository(IUnitOfWork inUnitOfWork)
        {
            return new DoctorRepository(inUnitOfWork);
        }

        public IMedicalExaminationRepository CreateMedicalExaminationRepository(IUnitOfWork inUnitOfWork)
        {
            return new MedicalExaminationRepository(inUnitOfWork);
        }

        public IPatientRepository CreatePatientRepository(IUnitOfWork inUnitOfWork)
        {
            return new PatientRepository(inUnitOfWork);
        }

        public IMedicalFindingRepository CreateMedicalFindingRepository(IUnitOfWork inUnitOfWork)
        {
            return new MedicalFindingRepository(inUnitOfWork);
        }

        public IDiagnosisRepository CreateDiagnosisRepository(IUnitOfWork inUnitOfWork)
        {
            return new DiagnosisRepository(inUnitOfWork);
        }

        public IExaminationTypeRepository CreateExaminationTypeRepository(IUnitOfWork inUnitOfWork)
        {
            return new ExaminationTypeRepository(inUnitOfWork);
        }

        public IEmployeeRepository CreateEmployeeRepository(IUnitOfWork inUnitOfWork)
        {
            return new EmployeeRepository(inUnitOfWork);
        }
    }
}
