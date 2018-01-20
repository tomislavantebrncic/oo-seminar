using BaseLib;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PatientController : IPatientController
    {
        private readonly IWindowFormsFactory _formsFactory = null;
        private readonly IRepositoryFactory _repositoryFactory = null;

        public PatientController(IWindowFormsFactory inFormsFactory, IRepositoryFactory inRepositoryFactory)
        {
            _formsFactory = inFormsFactory;
            _repositoryFactory = inRepositoryFactory;
        }

        public void ViewSelectPatient(ISelectPatientView inForm)
        {
            inForm.ShowModaless(this);
        }

        public IList<Patient> SearchPatients(string inLastName)
        {
            var patientRepository = _repositoryFactory.CreatePatientRepository();

            return patientRepository.GetAllByLastName(inLastName);
        }

        public void UpdateAddMedicalExaminationPatient(Patient inPatient)
        {
            throw new NotImplementedException();
        }
    }
}
