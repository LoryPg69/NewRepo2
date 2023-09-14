using System;
using System.Collections.Generic;
using System.IO;

namespace EsercizioBankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            ContoCorrente conto = new ContoCorrente(1000);

            Console.WriteLine("ACCEDI");
            accounts.Add(new Account("lollo", "lollo04", conto.Saldo));
            accounts.Add(new Account("fede", "fede01", conto.Saldo));
            accounts.Add(new Account("fra", "fra09", conto.Saldo));

            conto.Accedi(accounts);
            conto.SchermataBenvenuto();
            conto.MenuConto(accounts);

        }
    }
}
