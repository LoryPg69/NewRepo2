using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformer
{
    internal class Jet
    {
        public int wheels, max_value;
        public string t;
        public Jet( string t, int wheels, int max_value) 
        {
            this.t = t;
            this.wheels = wheels;
            this.max_value = max_value;

        }    

        public string Run() {

            if (t == "Jet")
            {
                Console.WriteLine("Vola"); return t;
            }
            else if (t == "Car") { Console.WriteLine("Strada"); return t; }

            else if (t == "Boat") { Console.WriteLine("Acqua"); return t; }
            
            else { Console.WriteLine("Errore di scrittura");  } 
            

        }
    }
}
