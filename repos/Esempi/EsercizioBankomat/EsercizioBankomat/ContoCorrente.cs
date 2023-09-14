using System;
using System.Collections.Generic;

namespace EsercizioBankomat
{
    public class ContoCorrente
    {
        public string User { get; set; }

        public double result { get; set; }
        public double Saldo { get; set; }

        public double Cifra { get; set; }
        public ContoCorrente(double saldo)
        {

            Saldo = saldo;

        }


        internal void Prelievo(double cifra)
        {
            bool s = false;
            double r;


            do
            {
                Console.WriteLine("Inserisci cifra");
                cifra = Double.Parse(Console.ReadLine());
                if (cifra > Saldo)
                {
                    Console.WriteLine("Cifra troppo alta");
                }
                else
                {
                    r = Saldo - cifra;
                       Console.WriteLine($"Il saldo è di {r}");
                    result = r;             
                    s  = true;
                }

            } while (!s);          

        }



        internal void Versamento(double cifra)
        {
            Console.WriteLine("Inserisci cifra");
            cifra = Double.Parse(Console.ReadLine());
             result = Saldo + cifra;
            Console.WriteLine($"Il saldo è di {result}");

        }

        

        internal void VisualizzaSaldo()
        {
            Console.WriteLine($"Il tuo saldo è di {result}");

        }

        public void SchermataBenvenuto()
        {
            Console.WriteLine($"BENVENUTO");
        }

        public void Accedi(List<Account> accounts)
        {
            bool trovato = false;
            do
            {
                Console.WriteLine("inserisci username: ");
                string username = Console.ReadLine();
                Console.WriteLine("inserisci password: ");
                string password = Console.ReadLine();

                

                foreach (Account account in accounts)
                {

                    if (username.Equals(account.Username) && password.Equals(account.Password))
                    {
                        Console.WriteLine("utente trovato");
                        trovato = true;

                    }


                }
                if (!trovato)
                {
                    Console.WriteLine("utente non trovato o password sbagliata");
                    
                }
               
            } while (!trovato);
            MenuConto();
            SchermataBenvenuto();

        }


        public void MenuConto()
        {
            Console.WriteLine("Scegli 1 per prelevare, 2 per versare, 3 per visualizzare il saldo 4 per uscire");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Prelievo(Cifra);
                    MenuConto();
                    break;
                case 2:

                    Versamento(Cifra);
                    MenuConto();
                    break;
                case 3:

                    VisualizzaSaldo();
                    MenuConto();
                    break;
                case 4:
                    Console.WriteLine("Arrivederci");
                    return;

                default:
                    Console.WriteLine("numero sbagliato");
                    return;

            }
        }

    }
}
