using Model;
using Model.Repositories;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class MedicalExaminationService : Service<MedicalExamination, int>, IMedicalExaminationService
    {
        public MedicalExaminationService(IMedicalExaminationRepository inRepository) {
            repository = inRepository;
        }
        
        public List<MedicalExamination> GetAllByDoctorAndNonExamined(int id)
        {
            return ((IMedicalExaminationRepository)repository).GetAllByDoctorAndNonExamined(id);
        }

        public List<MedicalExamination> GetAllByWaitingRoom(int id)
        {
            WaitingRoom waitingRoom = new WaitingRoom();
            foreach(MedicalExamination m in ((IMedicalExaminationRepository)repository).GetAllByWaitingRoom(id))
            {
                waitingRoom.AddExamination(m);
            }
            //return ((IMedicalExaminationRepository)repository).GetAllByWaitingRoom(id);
            return (List<MedicalExamination>)waitingRoom.Examinations;
        }
    }
}
