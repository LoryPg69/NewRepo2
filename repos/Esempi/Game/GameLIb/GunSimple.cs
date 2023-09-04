using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLIb
{
    public class GunSimple : IGun 

    {
        public void Shoot()
        {
            Console.WriteLine($"Shoot ");
        }
    }
}
