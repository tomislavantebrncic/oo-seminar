using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MedicalFindingDescription : Entity<int>
    {
        public string Anamnesis { get; set; }
        public string Therapy { get; set; }
        public string Status { get; set; }
        public string Finding { get; set; }

        public MedicalFindingDescription(string anamnesis, string therapy, string status, string finding)
        {
            Anamnesis = anamnesis;
            Therapy = therapy;
            Status = status;
            Finding = finding;
        }
    }
}
