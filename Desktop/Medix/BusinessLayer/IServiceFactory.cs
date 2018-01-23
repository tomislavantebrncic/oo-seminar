namespace BusinessLayer
{
    public interface IServiceFactory
    {
        IDoctorService createDoctorService();
        IMedicalExaminationService createMedicalExaminationService();
        IMedicalFindingService createMedicalFindingService();
        IPatientService createPatientService();
        IDiagnosisService createMedicalDiagnosisService();
    }
}
