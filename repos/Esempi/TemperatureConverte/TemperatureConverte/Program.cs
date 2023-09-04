using System;

namespace TemperatureConverte
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Fahrenheit f = new Fahrenheit(5.0);
            Console.WriteLine("Dato in Fahrenheit: ");
            Console.WriteLine(f);
            //f.Converse();
            f.Display();
            Celsius c = new Celsius(3.0);
            Console.WriteLine("Dato in Celsius");
            Console.WriteLine(c);
            //c.Converse();
            c.Display();




        }
    }
}
