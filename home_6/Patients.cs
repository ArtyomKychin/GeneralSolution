using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_6
{
    public class Patient 
    {
        public string Name { get; set; }
        public IlnessType IlnessType { get; set; }
        public bool IsIll { get; set; }

        public Patient(string name, IlnessType ilnessType, bool isIll )
        {
            Name = name;
            IlnessType = ilnessType;
            IsIll = isIll;
        }
    }
}
