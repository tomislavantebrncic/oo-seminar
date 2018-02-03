using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MedicalFinding : Entity<int>
    {
        public virtual DateTime Date { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual String Anamnesis { get; set; }
        public virtual String Therapy { get; set; }
        public virtual String Status { get; set; }
        public virtual String Finding { get; set; }

        public virtual MedicalDiagnosis MedicalDiagnosis { get; set; }

        public MedicalFinding()
        {

        }

        public MedicalFinding(DateTime date, Doctor doctor, Patient patient, MedicalDiagnosis medicalDiagnosis)
        {
            Date = date;
            Doctor = doctor;
            Patient = patient;
            MedicalDiagnosis = medicalDiagnosis;
        }
    }
}
