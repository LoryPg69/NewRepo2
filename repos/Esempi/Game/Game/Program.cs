using GameLIb;
using System;


namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Game!");
  
            Player p = new Player(new GunSimple());
            p.Shoot();
            
            p.CurrentGun = new GunLaser();
            p.changeArm(1);
            p.Shoot();
            p.CurrentGun = new GunSight();
            p.Shoot();

            IGun c = new GunSimple(); // casting senza il boxing

            
        }
    }
}
