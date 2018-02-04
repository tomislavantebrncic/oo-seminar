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
        private string _name;
        private Doctor _doctor;

        public virtual IList<MedicalExamination> Examinations
        {
            get { return _examinations; }
            set { _examinations = value; }
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual Doctor Doctor
        {
            get { return _doctor; }
            set { _doctor = value; }
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
            if (inMedicalExamination.ExaminationDate.Day.Equals(today.Day) && !inMedicalExamination.Examined)
            {
                _examinations.Add(inMedicalExamination);
            }
        }
    }
}
