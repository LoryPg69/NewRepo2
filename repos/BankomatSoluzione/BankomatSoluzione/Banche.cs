using System;
using System.Collections.Generic;


namespace BankomatSimulazione
{
  
    public partial class Banche
    {      
        public Banche()
        {
            this.Banche_Funzionalita = new HashSet<Banche_Funzionalita>();
            this.Utenti = new HashSet<Utenti>();
        }
    
        public long Id { get; set; }
        public string Nome { get; set; }
    
        public virtual ICollection<Banche_Funzionalita> Banche_Funzionalita { get; set; }
        public virtual ICollection<Utenti> Utenti { get; set; }
    }
}
