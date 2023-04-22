using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_7
{
    internal class Cook : ICooking, ICleaning
    {
        public string Name { get; set; }
        public Cook(string name)
        {
            Name = name;
        }
        public void DoCleaning()
        {
            Console.WriteLine($"Cook {Name} is cleaning");
        }
        public void DoCooking()
        {
            Console.WriteLine($"Cook {Name} is cooking");
        }
        public override string ToString()
        {
            return $"Hi, im Cook {Name}";
        }
    }
}
