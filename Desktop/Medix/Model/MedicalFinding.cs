﻿using System;
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
        public virtual MedicalFindingDescription FindingDesc { get; set; }
        public virtual MedicalDiagnosis MedicalDiagnosis { get; set; }

        public MedicalFinding()
        {

        }

        public MedicalFinding(DateTime date, Doctor doctor, Patient patient, MedicalFindingDescription medicalFindingDescription, MedicalDiagnosis medicalDiagnosis)
        {
            Date = date;
            Doctor = doctor;
            Patient = patient;
            FindingDesc = medicalFindingDescription;
            MedicalDiagnosis = medicalDiagnosis;
        }
    }
}
