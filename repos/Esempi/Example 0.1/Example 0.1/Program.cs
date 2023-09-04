using System;

namespace Example_0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EnumExample();


            structExample();

            Person pippo = new Person("Pippo", 30);
           

            pippo.Display();

            Person pluto = new Person("Pluto", 20);
            pluto.Display();

           //Worker w1 = new Worker("Giovanni", 23, 20000, 32);
           //w1.Display();
           // Console.WriteLine(w1.Wage);
           // Console.WriteLine(w1.Age);

           // Worker w2 = new Worker("Lorenzo", 22, 50000, 45);
           // w2.Display();

            //string codAzieda = Worker.CodiceAzienda;
            //Console.WriteLine(codAzieda);

            //string tesserino = Worker.MakeTesserino(w2.Name);
            //Console.WriteLine(tesserino);

            Worker w1 = Worker.CreateWorker("Lorenzo", 22, 50000, 45);
            Console.WriteLine(w1.Name);

            Worker w2 = Worker.CreateWorker("Paolo", 16, 50000, 45);
            Console.WriteLine(w2.Name);

        }

        private static void structExample()
        {
            Vector vs = new Vector();
            vs.X = 1;
            vs.Y = 4;
            Console.WriteLine($"X: {vs.X} Y: {vs.Y}");

            Vector vb = new Vector(10, 20);
        }

       
        

        //private static void EnumExample()
        //{
        //    Status player = Status.Alive;

        //    switch (player)
        //    {
        //        case Status.Alive:
        //            Console.WriteLine("Good");
        //            break;
        //        case Status.Injured:
        //            Console.WriteLine("SO SO");
        //            break;
        //        case Status.Dead:
        //            Console.WriteLine("Game Over");
        //            break;
        //        default:
        //            Console.WriteLine("no status player");
        //            break;
        //    }
        //}
        struct Vector
        {
            public int X; public int Y;
            public Vector(int x, int y)
            {
                X = x;  
                Y = y;
               
            }
        }

        enum Status
        {
        Alive = 0,
        Injured = 1,
        Dead = 2
        }
    }
}
