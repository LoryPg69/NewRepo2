using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xtc = new ordersEntities();
            Console.WriteLine(xtc);
           foreach( customers c in xtc.customers)
            {
                Console.WriteLine(c.customer + "" + c.country);
            }

        }
    }
}
    