using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLIb
{
    public interface GunSight
    {
        public void Shoot()
        {
            Console.WriteLine($"Shoot ");
        }
    }
}
