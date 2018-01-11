using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WaitingRoom : Entity<int>
    {
        public Doctor Doctor { get; set; }
        public Nurse Nurse { get; set; }
        public List<Patient> Patients { get; set; }

        public WaitingRoom(int inID) : base(inID)
        {

        }
    }
}
