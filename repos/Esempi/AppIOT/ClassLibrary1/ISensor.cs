using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIOT
{
    internal interface ISensor
    {
        public double NumSensori { get; set; }
        public double temperatura { get; set; }
        public double umidità { get; set; }
        public double co2 { get; set; }
        
        void Print();
    }
}
