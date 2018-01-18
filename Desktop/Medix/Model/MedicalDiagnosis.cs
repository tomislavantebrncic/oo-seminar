using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MedicalDiagnosis : Entity<int>
    {
        public virtual string NameHRV { get; set; }
        public virtual string NameLAT { get; set; }

        public MedicalDiagnosis()
        {

        }

        public MedicalDiagnosis(string nameHRV, string nameLAT)
        {
            NameHRV = nameHRV;
            NameLAT = nameLAT;
        }

        public MedicalDiagnosis(int inID) : base(inID)
        {
        }
    }
}
