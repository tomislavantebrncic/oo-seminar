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
    public class ExaminationController
    {
        public void ViewNewExamination(Patient inPatient, INewExaminationView inForm, IMedicalExaminationRepository examinationRepository, IMainFormController mainController)
        {
            //List<MedicalExamination> listExaminations = waitingRoomRepository.getAllExaminations();

            inForm.ShowModaless(inPatient, mainController);
        }
    }
}
