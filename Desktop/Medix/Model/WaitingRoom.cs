using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WaitingRoom : Entity<int>
    {
        public virtual IList<MedicalExamination> Examinations { get; set; }
        public virtual string Name { get; set; }

        public WaitingRoom()
        {

        }

        public WaitingRoom(int inID, IList<MedicalExamination> inExaminations, string inName) : base(inID)
        {
            Examinations = inExaminations;
            Name = inName;
        }
    }
}
