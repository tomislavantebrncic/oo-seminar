using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WaitingRoom : Entity<int>
    {
        //public virtual Doctor Doctor { get; set; }
        //public virtual Nurse Nurse { get; set; }
        public virtual IList<MedicalExamination> Examinations { get; set; }

        public WaitingRoom()
        {

        }

        public WaitingRoom(int inID, IList<MedicalExamination> inExaminations) : base(inID)
        {
            Examinations = inExaminations;
        }
    }
}
