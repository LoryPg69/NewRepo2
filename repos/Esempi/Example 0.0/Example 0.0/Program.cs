using System;

namespace Example_0._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int e = 10;
            double d = e + 5.23;
            //int j = (int) d; conversione 


            string name = "Paolo";
            //double test = name;

            string s = "22";
            int age = int.Parse(s); //parsing: traduzione di una stringa in un intero //
            Console.WriteLine(int.MinValue); // stampano il range di quel tipo: il minimo e il massimo
            Console.WriteLine(int.MaxValue);



           // Console.WriteLine("Hello World!"); //


           /* var qui = true;
            // array //
            int[] array1 = new int[10];
            
            Console.WriteLine(array1[1]); // stampa array nella posizione 1 //
            array1[2] = 10;

            // matrici o array multidimensionali //

           
            Console.WriteLine(array3.Length); //lunghezza dell'array //

            // guardia --> return //

          /* if (qui) // variabile booleana //
            {
                Console.WriteLine("qui");    // per un if c'è bisogno di almeno un else //
                return;

            }
            else
            {
                Console.WriteLine("all ");
            }
            int vs = 2;

            if (vs == 0) // variabile booleana //
            {
                Console.WriteLine("qui");    // per un if c'è bisogno di almeno un else //
                return;

            }
            else if (vs == 2)
            {
                Console.WriteLine("all ");
            }
            else
            {
                Console.WriteLine("esci");
            }

            string username = "pippo";
            if (username == null)
            {

                username = "default user";
            } */

            int[][] array3 = new int[][]
           {
                new int[] {1, 2 },
                new int[] {3, 4, 10, 20},
                new int[] {5, 6, 7},

           };

            int[] array2 = new int[] { 6, 2, 73 };

            /* for (int i  = 0; i < 10; i++)
             {
                 Console.WriteLine(i);
             }
            */
            /*for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                   Console.WriteLine(" {0} ",array3[i][j]);
                }
                }
            */

            /* foreach (int a in array2)
             {



                 if (a < 5)
                 {
                     //continue;
                     //break;
                     //return;
                     //throw new Exception("nuova eccezione");
                 }

                 Console.WriteLine(a);
             }
 */
            firstMethod();
            string pippo = secondMethod("Paolo");
            Console.WriteLine(pippo);

            string pluto = secondMethod("Paolo", 5);

            if (pluto != null)
            {
                Console.WriteLine("ok");
            }

            else
            {
                Console.WriteLine("no ok");
            }

            Console.WriteLine("end of program");

            Console.ReadKey();
        }
        public static void firstMethod()
        {
            Console.WriteLine("Hello from first method");


        }

        private static string secondMethod(string name)
        {
            string result = string.Format("Hello {0} from second method", name); //{0} placeholder // // string format//
            return result;
        }

        private static string secondMethod(string name, int times) //overloading//
        {
            string result = string.Format("Hello {0} from second method", name);

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"{i+1} - {result}");
            }
            return result;
        }

        int myMehod ( params int[] args )
        {
            int add = 0;

            foreach ( int item in args )
            {
                add += item;
            }
            return add;
        }
    }
}


