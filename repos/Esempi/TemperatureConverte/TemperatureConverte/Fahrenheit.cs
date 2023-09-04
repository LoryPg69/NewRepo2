using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverte
{
    internal class Fahrenheit
    {

       
        public Fahrenheit(double temp)
        {

            Temp = temp;

        }

        public double Temp { get; set; }

        public static implicit operator double(Fahrenheit f)
        {
            return f.Temp;
        }

        //public double Converse()
        //{

         
        //    double result = (Temp * 9.0 / 5.0) + 32;
        //    Celsius c = new Celsius(result);
        //    return c;

        //}

        public void Display()
        {

            Console.WriteLine($"la temperatura da Fahrenheit a Celsius è {(Temp - 32) * 5 / 9} ");

        }
    }
}
