using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirittiUmaniUnioneEuropea
{
    public class EuroZoneCountry : EUCountry, IEuroZone
    {
        // ONU Contracts
        // EURO Contracts
        // EU Contracts 

        public EuroZoneCountry(string Name, string State, string Government, string Constitution)
            : base(Name, State, Government, Constitution)
        {

        }


        public void Euro()
        {
            //Contratto EURO ZONA 
        }
    }
}
