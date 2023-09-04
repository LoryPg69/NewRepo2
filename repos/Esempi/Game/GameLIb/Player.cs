using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLIb
{
    public class Player
    {
        public Guid Id { get; set; }
        public int Life { get; set; }

        public Inventory Arms { get; set; }

        public IGun CurrentGun { get; set; }



        public Player(IGun gun)
        {
            Id = Guid.NewGuid();
            CurrentGun = gun;

        }

        public void changeArm(int i)
        {

            //switch (i)
            //{
            //    case 0:
            //        CurrentGun = Arms.Guns[i];
            //        break;
            //    case 1:
            //        CurrentGun = Arms.Guns[i];
            //        break;
            //    case 2:
            //        CurrentGun = Arms.Guns[i];
            //        break;
            //    default:
            //        CurrentGun = Arms.Guns[0];
            //        break;
            //}

        }

        public void Shoot()
        {
            CurrentGun.Shoot(); 
        }
    }
}