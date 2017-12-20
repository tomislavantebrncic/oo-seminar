using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Word : EntityBase<int>
    {
        public string Text { get; set; }
        public int BaseWordID { get; set; }

        public Word() : base(0)
        {
        }

        public Word(int inID, string inText) : base(inID)
        {
            Text = inText;
        }
    }
}
