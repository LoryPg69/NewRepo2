using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    internal class Immobili
    {
        public string alfanumerico;
        public string indirizzo;
        public string cap;
        public string citta;
        public int superficie;

        public Immobili( string alfanumerico, string indirizzo, string cap, string citta, int superficie) {
        
            this.alfanumerico=alfanumerico;
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.citta = citta;
            this.superficie = superficie;


        
        }
    }

    public string tipo( string proprita, string proprieta)
    {
        return proprieta;
    }
}
