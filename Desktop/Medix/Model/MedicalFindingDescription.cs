using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MedicalFindingDescription : Entity<int>
    {
        public MedicalDiagnosis Diagnosis { get; set; }
        public string Anamnesis { get; set; }
        public string Therapy { get; set; }
        // u skici imamo jos i status al nisam ziher za sta nam je to trebalo 
        //isto za nalaz, sta nije ovo nalaz?
        public ExaminationType ExaminationType { get; set; }

        public MedicalFindingDescription(MedicalDiagnosis diagnosis, string anamnesis, string therapy, ExaminationType examinationType)
        {
            Diagnosis = diagnosis;
            Anamnesis = anamnesis;
            Therapy = therapy;
            ExaminationType = examinationType;
        }
    }
}
