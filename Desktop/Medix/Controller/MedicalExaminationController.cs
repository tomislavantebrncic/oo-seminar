using BaseLib;
using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MedicalExaminationController
    {
        IRepositoryFactory _repositoryFactory = null;

        public MedicalExaminationController(IRepositoryFactory inRepositoryFactory)
        {
            _repositoryFactory = inRepositoryFactory;
        }
        
        public void AddNewMedicalExamination(IAddMedicalExaminationView inForm)
        {
            if (inForm.ShowViewModal())
            {
                try
                {
                    string PatientId = inForm.PatientId;

                    IPatientRepository patientRepository = _repositoryFactory.CreatePatientRepository();

                    Patient patient = patientRepository.Get(PatientId);

                    if (patient == null)
                    {
                        string FirstName = inForm.PatientFirstName;
                        string LastName = inForm.PatientLastName;
                        string OIB = inForm.PatientOIB;
                        DateTime DateOfBirth = DateTime.ParseExact(inForm.PatientDateOfBirth, "dd.MM.yyyy", CultureInfo.InvariantCulture);

                        patient = new Patient(FirstName, LastName, OIB, DateOfBirth, PatientId);
                    }

                    MedicalExamination medicalExamination = new MedicalExamination();

                    IMedicalExaminationRepository medicalExaminationRepository = _repositoryFactory.CreateMedicalExaminationRepository();

                    medicalExaminationRepository.Add(medicalExamination);
                }
                catch (Exception ex)
                {
                    
                }
            }
        }
    }
}
