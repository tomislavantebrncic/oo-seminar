using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MedicalFindingDescription : Entity<int>
    {
        public virtual string Anamnesis { get; set; }
        public virtual string Therapy { get; set; }
        public virtual string Status { get; set; }
        public virtual string Finding { get; set; }

        public MedicalFindingDescription()
        {

        }

        public MedicalFindingDescription(string anamnesis, string therapy, string status, string finding)
        {
            Anamnesis = anamnesis;
            Therapy = therapy;
            Status = status;
            Finding = finding;
        }
    }
}
