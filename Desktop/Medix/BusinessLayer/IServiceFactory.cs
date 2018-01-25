﻿using BaseLib;

namespace BusinessLayer
{
    public interface IServiceFactory
    {
        IDoctorService createDoctorService(IUnitOfWork inUnitOfWork);
        IMedicalExaminationService createMedicalExaminationService(IUnitOfWork inUnitOfWork);
        IMedicalFindingService createMedicalFindingService(IUnitOfWork inUnitOfWork);
        IPatientService createPatientService(IUnitOfWork inUnitOfWork);
        IDiagnosisService createMedicalDiagnosisService(IUnitOfWork inUnitOfWork);
        IStatisticsService createStatisticsService(IUnitOfWork inUnitOfWork);
        IExaminationTypeService CreateExaminationTypeService(IUnitOfWork inUnitOfWork);
    }
}
