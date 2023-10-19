using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//utilizzo delle interfacce e una delle tante forme di polimorfismo
namespace Interface_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Id = "001";
            persona.Nome = "Emilio";
            persona.Cognome = "Scaccaglia";
            persona.AnnoIscrizione = 2015;

            Organizzazione organ = new Organizzazione();
            organ.Id = "002";
            organ.RagioneSociale = "System Logistics";
            organ.AnnoIscrizione = 2018;

            Organizzazione organ2 = new Organizzazione();
            organ2.Id = "003";
            organ2.RagioneSociale = "Randstad";
            organ2.AnnoIscrizione = 2023;

            Persona persona2 = new Persona();
            persona2.Id = "004";
            persona2.Nome = "Andrea";
            persona2.Cognome = "Calligari";
            persona2.AnnoIscrizione = 2020;


            //Biblioteca biblio = new Biblioteca();
            Biblioteca.utenti = new IUtente[] { persona, organ, organ2, persona2};
            Biblioteca.stampaUtenti();

            Console.Read();
        }
    }

    public interface IUtente
    {
        //le proprietà sotto riportate sono per definizione "public" e "abstract"
        string Id { get; set; }
        int AnnoIscrizione { get; set; }
        string Descrizione { get; }

        void Stampa();
    }

    public class Persona : IUtente
    {
        //notare che le tre proprietà sono definite "public"
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Descrizione { get { return Id + " " + Nome + " " + Cognome; } }

        public string Nome { get; set; }
        public string Cognome { get; set; }

        public void Stampa()
        {
            Console.WriteLine("Persona");
        }
    }

    public class Organizzazione : IUtente
    {
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Descrizione { get { return Id + " " + RagioneSociale; } }

        public string RagioneSociale { get; set; }

        public void Stampa()
        {
            Console.WriteLine("Organizzazione");
        }

    }

    public class Biblioteca
    {
        //questo è un array di interfacce utente ovvero di IUtente
        public static IUtente[] utenti;

        public static void stampaUtenti()
        {
            foreach (IUtente utente in utenti)
            {
                Console.WriteLine(utente.Descrizione);
                utente.Stampa();
            }
        }
    }
}
