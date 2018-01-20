using BaseLib;
using Model;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MedicalFindingFormController : IMedicalFindingFormController
    {
        IRepositoryFactory _repositoryFactory = null;
        Patient patient;

        public MedicalFindingFormController(IRepositoryFactory inRepositoryFactory, Patient inPatient)
        {
            _repositoryFactory = inRepositoryFactory;
            patient = inPatient;
        }

        public void AddNewMedicalFinding(IMedicalFindingView inForm)
        {
            inForm.ShowModaless(patient);
        }
    }
}
