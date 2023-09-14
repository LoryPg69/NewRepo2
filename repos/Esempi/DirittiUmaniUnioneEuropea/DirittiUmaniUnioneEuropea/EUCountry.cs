using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DirittiUmaniUnioneEuropea
{
    public class EUCountry : Country, IEuropeanUnion, IEUCountry
    {
        // UE Contracts
        public void HumanRights() { }
        public void ConstitutionIntegration()
        {
            Constitution += "EU Costitution";
            Console.WriteLine($"{Name} -  {Constitution}");
        }

        public EUCountry(string Name, string State, string Government, string Constitution) :
            base(Name, State, Government, Constitution)
        {
            ConstitutionIntegration();
        }




        // ONU Contracts
        public virtual void PopulationControl()
        {


            Console.WriteLine("Polizia di Frontiera");
            Console.WriteLine("--------------------------------");

        }
        public virtual void TerritoryControl()
        {

            Console.WriteLine("ARMY");
            Console.WriteLine("--------------------------------");

        }

        public void Permesso(EuroZoneCountry euroZoneCountry)
        {
            Console.WriteLine($"Ho ottenuto il permesso di soggiorno dal paese {euroZoneCountry.Name}");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
