using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverte
{
    internal class Celsius
    {

        
       

        public double Temp { get; set; }

        public Celsius(double temp) {

                Temp = temp;
            }

        public static implicit operator double(Celsius c)
        {
            return c.Temp;
        }

        //public double Converse () {

            
        //       double result= ;
        //    Fahrenheit f = new Fahrenheit(result);
        //    return f;
        //}

        public void Display()
        {

            Console.WriteLine($"la temperatura da Celsius a Fahrenheit è {(Temp * 9.0 / 5.0) + 32}");

        }

    }
}
