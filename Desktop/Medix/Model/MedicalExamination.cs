using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MedicalExamination : Entity<int>
    {
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime ExaminationDate { get; set; }
        public ExaminationType ExaminationType { get; set; }
        public bool Examined { get; set; }

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
