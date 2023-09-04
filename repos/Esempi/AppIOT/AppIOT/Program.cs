using System;
using System.Collections.Generic;

namespace AppIOT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            DeviceIoT pro1 = new DeviceIoT()
            
            {
                Model = "Pro1",
                Sensors = new List<Sensor>()
                {
                    new Sensor(1),
                    new Sensor(2),
                    new Sensor(3),
                    new Sensor(4)
                    
                }
               

            };


            DeviceIoT pro2 = new DeviceIoT()
            {
                Model = "Pro2",
                Sensors = new List<Sensor>()
                {
                    new Sensor(1),
                    new Sensor(2),
                    new Sensor(3),
                    new Sensor(4)
                }

            };
            
            DeviceIoT Super = new DeviceIoT()
            {
                Model = "Super",
                Sensors = new List<Sensor>()
                {
                    new Sensor(1),
                    new Sensor(2),
                    new Sensor(3),
                    new Sensor(4),
                    new Sensor(5),
                    new Sensor(6),
                    new Sensor(7),
                    new Sensor(8),
                }

            };

            //Sensor s1 = new Sensor(3);
            //    s1.MisuraCO2();
            //    s1.MisuraUmidità();
            //    s1.MisuraTemperatura();
            //    s1.Print();
        }
    }







}
    

