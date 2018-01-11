using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MedicalFinding : Entity<int>
    {
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public MedicalFindingDescription _findingDesc { get; set; }

        public MedicalFinding(int inID) : base(inID)
        {

        }
    }
}
