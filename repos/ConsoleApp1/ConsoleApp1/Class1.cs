using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TestNumber
    {
        public TestNumber(int number) {
            if (number > 100 || number < 0) throw new ArgumentOutOfRangeException();
            this.Number = number;

        }
        public void setNumber(int number) { 
            if (number > 100 || number < 0) throw new ArgumentOutOfRangeException();
            this.Number = number;
            }

        public int Number { 
            get { return this.Number; }
             }

        public int classicNumber;



    }
   
}
