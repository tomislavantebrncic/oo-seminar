using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Statistics
    {
        public List<MedicalExamination> examinations { get; set; }
        public float priceSum { get; set; }
        public int patientCount { get; set; }
        public Doctor doctor { get; set; }

        public Statistics(List<MedicalExamination> inExaminations)
        {
            examinations = inExaminations;
        }

        public void Calculate()
        {
            doctor = examinations.First().Doctor;
            priceSum = 0;
            List<Patient> patients = new List<Patient>();
            foreach (MedicalExamination e in examinations)
            {
                priceSum += e.ExaminationType.Price;
                if (!patients.Contains(e.Patient))
                {
                    patients.Add(e.Patient);
                }
            }
            patientCount = patients.Count;
        }
    }
}
