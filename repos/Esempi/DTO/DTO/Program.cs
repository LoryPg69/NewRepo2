using System;
using System.Collections.Generic;

namespace DTO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        enum Stati
        {
            Invio1,
            Invio2, 
            OffAcc,
            OffRif,
        }

        class Offerta {             //DTO 
            int id {  get; set; }
            Preventivo p { get; set; }
            Stati stati { get; set; }

        }

        class Prodotti
        {
            string nome { get; set; }   
            string prezzo { get; set; }
        }

        class Preventivo { 
        
            List<Prodotti> list { get; set; }
            double tot { get; set; }

        }
    }
}
