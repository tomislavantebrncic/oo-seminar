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
            Examinations = new List<MedicalExamination>();
        }

        public WaitingRoom(int inID, IList<MedicalExamination> inExaminations, string inName) : base(inID)
        {
            if (inExaminations == null)
            {
                Examinations = new List<MedicalExamination>();
            }
            else
            {
                Examinations = inExaminations;
            }
            Name = inName;
        }

        public virtual void AddExamination(MedicalExamination inMedicalExamination)
        {
            DateTime today = DateTime.Today;
            if (inMedicalExamination.ExaminationDate.Day.Equals(today.Day))
            {
                Examinations.Add(inMedicalExamination);
            }
        }
    }
}
