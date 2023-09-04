using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLIb
{
    public class Inventory
    {
        public Inventory() {
            
         Guns = new List<Gun> { 
         
             new Gun(SightType.NoSight),
             new Gun(SightType.NormalSight),
             new Gun(SightType.LaserSight)

         };
        }
        public List<Gun> Guns { get; set; }
    }
}
