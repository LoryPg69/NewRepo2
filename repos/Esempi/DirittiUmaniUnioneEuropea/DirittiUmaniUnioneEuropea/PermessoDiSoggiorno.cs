using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirittiUmaniUnioneEuropea
{
    internal class PermessoDiSoggiorno : EUCountry, IONU, IEuropeanUnion
    {
        public PermessoDiSoggiorno(string Name, string State, string Government, string Constitution) : base(Name, State, Government, Constitution)
        {
        }

        internal static void Permesso(IONU italy)
        {
            throw new NotImplementedException();
        }

        public void Permesso(EuroZoneCountry euroZoneCountry) 
        { 
            Console.WriteLine($"Ho ottenuto il permesso di soggiorno dal paese {euroZoneCountry.Name}");
        }
            }
}
