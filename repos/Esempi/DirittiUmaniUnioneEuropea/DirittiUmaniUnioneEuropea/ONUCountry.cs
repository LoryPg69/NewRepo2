using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirittiUmaniUnioneEuropea
{
    
    public class ONUCountry : Country, IONU
    {
        public void PopulationControl() { }
        public void TerritoryControl() { }
        public ONUCountry(string Name, string State, string Government, string Constitution) :
           base(Name, State, Government, Constitution)
        {
           
        }
    }
}
