using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MedicalExamination : Entity<int>
    {
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual DateTime ExaminationDate { get; set; }
        public virtual ExaminationType ExaminationType { get; set; }
        public virtual bool Examined { get; set; }

        public MedicalExamination()
        {

        }

        public MedicalExamination(Doctor inDoctor, Patient inPatient, DateTime inDate, ExaminationType inExaminationType) : base()
        {
            Doctor = inDoctor;
            Patient = inPatient;
            ExaminationDate = inDate;
            ExaminationType = inExaminationType;
            Examined = false;
        }

        public MedicalExamination(int inId, Doctor inDoctor, Patient inPatient, DateTime inDate, ExaminationType inExaminationType) : base(inId)
        {
            Doctor = inDoctor;
            Patient = inPatient;
            ExaminationDate = inDate;
            ExaminationType = inExaminationType;
            Examined = false;
        }
    }
}
