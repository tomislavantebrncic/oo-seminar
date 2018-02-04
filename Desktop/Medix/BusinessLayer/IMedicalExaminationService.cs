using Model;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IMedicalExaminationService : IService<MedicalExamination, int>
    {
        List<MedicalExamination> GetAllByDoctorAndNonExamined(int id);
        List<MedicalExamination> GetAllByWaitingRoom(int id);
        MedicalExamination Add(Patient inPatient, ExaminationType inExaminationType, bool isEmergency);
    }
}