using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_7
{
    internal class Cleaner : ICleaning
    {
    public string Name { get; set; }     
        public Cleaner(string name)
        {
            Name = name;
        }
 
        public void DoCleaning()
        {
            Console.WriteLine($"Cleaner {Name} is cleaning");
        }

        public override string ToString()
        {
            return $"Hi, im Cleaner {Name}";
        }
    }

}
