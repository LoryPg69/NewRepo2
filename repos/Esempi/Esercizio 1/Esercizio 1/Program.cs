using System;

namespace Esercizio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ris;
            double n1, n2;
            Console.WriteLine("1 - Addiction");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplation");
            Console.WriteLine("4 - Division");
            do
            {
                Console.WriteLine("Scegli l'operazione");
                ris = Convert.ToInt32(Console.ReadLine());
            } while (ris < 1 || ris > 4);

            switch (ris)
            {

                default:
                case 1:
                    Console.WriteLine("Inserisci il primo numero");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Inserisci il primo numero");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"la somma fra {n1} e {n2} è {Addiction(n1, n2)}");
                    break;

                case 2:
                    Console.WriteLine("Inserisci il primo numero");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Inserisci il primo numero");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"la sottrazione fra {n1} e {n2} è {Subtraction(n1, n2)}");
                    break;
                case 3:
                    Console.WriteLine("Inserisci il primo numero");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Inserisci il primo numero");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"la moltiplicazione fra {n1} e {n2} è {Multiplation(n1, n2)}");
                    break;
                case 4:
                    Console.WriteLine("Inserisci il primo numero");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Inserisci il primo numero");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"la divisione fra {n1} e {n2} è {Division(n1, n2)}");
                    break;


            }



        }

        private static double Addiction(double n1, double n2)
        {
            return n1 + n2;
        }

        private static double Subtraction(double n1, double n2)
        {
            return n1 - n2;
        }

        private static double Multiplation(double n1, double n2)
        {
            return n1 * n2;
        }

        private static double Division(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
