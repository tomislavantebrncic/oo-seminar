using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ExaminationType : Entity<int>
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public ExaminationType(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }
}
