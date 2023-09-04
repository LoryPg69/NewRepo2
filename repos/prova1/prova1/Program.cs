// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ContoCorrente
    {
        decimal denaro;
        string codicefiscale;
        public ContoCorrente(decimal denaro, string codicefiscale)
        {
            this.denaro = denaro;
            this.codicefiscale = codicefiscale;
        }
        public void Prelievo(decimal denaro)
        {
            Console.WriteLine("quanto vuoi prelevare");
            decimal denarodesiderato = Convert.ToDecimal(Console.ReadLine());
            if (denaro > denarodesiderato)
            {
                denaro -= denarodesiderato;
                Console.WriteLine("ORA HAI " + denaro);
            }
            else Console.WriteLine("non puoi");
        }
        public void Versamento(decimal denaro)
        {
            Console.WriteLine("quanto vuoi versare");
            decimal denarodaversare = Convert.ToDecimal(Console.ReadLine());
            denaro += denarodaversare;
            Console.WriteLine("ORA HAI " + denaro);
        }
    }
}

