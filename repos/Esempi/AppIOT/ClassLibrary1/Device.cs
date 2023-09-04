using AppIOT;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class DeviceIoT : Isensor
    {
        public DeviceIoT()
        {
        }

        public string Model { get; set; }
        public List<Sensor> Sensors { get; set; }

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

            Console.WriteLine($"Umidità: {MisuraUmidità()}°C");
            Console.WriteLine($"Temperatura: {MisuraTemperatura()}°C");
            Console.WriteLine($"CO2: {MisuraCO2()} ppm");


        }
        public void PrintTemp()
        {

            Console.WriteLine($"Temperatura: {MisuraTemperatura()}°C");


        }

    }
}