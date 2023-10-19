using System;
using System.Collections.Generic;


namespace BankomatSimulazione
{

    public partial class ContiCorrente
    {
        public long Id { get; set; }
        public long IdUtente { get; set; }
        public int Saldo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }
        public DateTime UltimoVersamento { get; set; }
    
        public virtual Utenti Utenti { get; set; }
    }
}
