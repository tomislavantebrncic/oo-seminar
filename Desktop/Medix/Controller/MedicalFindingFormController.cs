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
        MedicalExamination examination;

        public MedicalFindingFormController(IRepositoryFactory inRepositoryFactory, MedicalExamination inExamination)
        {
            _repositoryFactory = inRepositoryFactory;
            examination = inExamination;
        }

        public void AddNewMedicalFinding(IMedicalFindingView inForm)
        {
            inForm.ShowModaless(examination);
        }

        public void saveFinding(MedicalFinding finding)
        {
            IMedicalFindingRepository repository = _repositoryFactory.CreateMedicalFindingRepository();
            repository.Add(finding);
        }
    }
}
