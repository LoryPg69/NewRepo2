using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIOT
{
    public class Sensor
    {
        private int numSensore;

        public Sensor(int v)
        {
            this.numSensore = v;
        }

        public int temperatura { get; set; }
        public int umidità { get; set; }
        public int co2 { get; set; }

        public double MisuraTemperatura()
        {
            var rand = new Random();
            double temperatura = rand.Next(1, 101);
            return temperatura;
        }
        public int MisuraCO2()
        {
            var rand = new Random();
            int co2 = rand.Next(1, 101);
            return co2;
        }

        public int MisuraUmidità()
        {
            var rand = new Random();
            int umidità = rand.Next(1, 101);
            return umidità;
        }

        public void Print()
        {
            for (int i = 0; i < numSensore; i++)
            {
                Console.WriteLine($"Umidità: {MisuraUmidità()}°C");
                Console.WriteLine($"Temperatura: {MisuraTemperatura()}°C");
                Console.WriteLine($"CO2: {MisuraCO2()} ppm");
            }

        }
        public void PrintTemp()
        {
            for ( int i = 0; i < numSensore; i++ ) { 
            Console.WriteLine($"Temperatura: {MisuraTemperatura()}°C");
            }


        }
    }
}
