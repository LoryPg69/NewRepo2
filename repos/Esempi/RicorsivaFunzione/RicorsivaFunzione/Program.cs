using System;
using System.Threading;

namespace RicorsivaFunzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
             C(5);

        }

        public int C (int start) {
            if (start == 0)
            {
                return start;


            }
            else return C (start - 1);
        
        }

    }
}
