using Model.Repositories;
using Model.RepositoryInterfaces;

namespace BaseLib
{
    public interface IRepositoryFactory
    {
        IPatientRepository CreatePatientRepository();
        IDoctorRepository CreateDoctorRepository();
        IMedicalExaminationRepository CreateMedicalExaminationRepository();
        IMedicalFindingRepository CreateMedicalFindingRepository();
        IDiagnosisRepository CreateDiagnosisRepository();
    }
}
