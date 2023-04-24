using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_7
{
    public class Manager : IManagement, ICooking
    {
        public string Name { get; set; }
        public Manager(string name)
        {
            Name = name;
        }
        public void DoManage()
        {
            Console.WriteLine($"Manager {Name} is managing people");
            Console.WriteLine($"Maneger {Name} is solving conflicts");
        }
        public void DoCooking()
        {
            Console.WriteLine($"Manager {Name} is cooking");
        }
        public override string ToString()
        {
            return $"Hi, im Manager {Name}";
        }
    }
}
