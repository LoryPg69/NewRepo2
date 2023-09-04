using System;

namespace Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 p = new Class1();
            //p.HitSpeed = 10;
            //badPlayer b = new badPlayer();
            //b.HitSpeed = 20;

            int[] age = new int[] {50};
            object boxedAge = age;
            int lenght = age.Length;
            int[] pippo = (int[])boxedAge;
            Console.WriteLine(pippo[0]);
        }
    }
}
