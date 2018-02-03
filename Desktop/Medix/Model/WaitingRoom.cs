using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WaitingRoom : Entity<int>
    {
        private IList<MedicalExamination> _examinations;
        public virtual string Name { get; set; }

        public virtual IList<MedicalExamination> Examinations
        {
            get { return _examinations.ToList(); }
            set { _examinations = value; }
        }

        public WaitingRoom()
        {
            Examinations = new List<MedicalExamination>();
        }

        public WaitingRoom(IList<MedicalExamination> inExaminations, string inName) : base()
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
