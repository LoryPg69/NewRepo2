using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio_0._2
{
    internal class TestClass
    {
        public static int Return1() { return 10; }

        public static int Return2( int v) {
            Console.WriteLine(v);
            
            return 10; }
        public static int Return3<T>(T v)
        {
            Console.WriteLine(v);

            return 10;
        }

        public static int Return4<T>(T v1, T v2)
        {
            Console.WriteLine($"{v1}, {v2}");

            return 10;
        }
    }
}
