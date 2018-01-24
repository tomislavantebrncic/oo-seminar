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
    }
}
