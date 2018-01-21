namespace BusinessLayer
{
    public class ServiceFactory : IServiceFactory
    {
        public IDoctorService createDoctorService()
        {
            return new DoctorService();
        }

        public IMedicalExaminationService createMedicalExaminationService()
        {
            return new MedicalExaminationService();
        }

        public IMedicalFindingService createMedicalFindingService()
        {
            return new MedicalFindingService();
        }

        public IPatientService createPatientService()
        {
            return new PatientService();
        }
    }
}
