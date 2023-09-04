using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_0._1
{
    internal class Worker : Person
    {
        //public static string CodiceAzienda = "djsja34";

        //fabricator

        public static Worker CreateWorker(string name, int age, double wage, int vacation)
        {

            if (age < 18) {

                Console.WriteLine("is not possible");
                throw new Exception("age < 18");

            }
        

        Worker w = new Worker(name, age, wage, vacation);
            w.CodiceAzienda = "ddjdjdjjdjd";
            return w;

        }
        public Worker(string name, int age, double wage, int vacation) : base(name, age) // base = è classe in cui stai derivando
        {
            Wage = wage;
            Vacation = vacation;
        }

        public string CodiceAzienda { get; private set; }

        public double Wage { get; set; } // formattazione di get e set
                                         // la variabile contenuta nella proprietà
        public int Vacation { get; set; }

        public static string MakeTesserino(string codice) { 
            return $" tesserino cod: {codice}"; 
        }
    }

     
}
