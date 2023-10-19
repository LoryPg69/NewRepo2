using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace differenzaAeM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public interface IVeicolo
        {
            //le proprietà sotto riportate sono per definizione "public" e "abstract"
            string Id { get; set; }

             string Marca { get; set; }
             string Modello { get; set; }
            string Descrizione { get; }
            int Cilindrata { get; set; }

            void Stampa();
        }

        public class Macchina : IVeicolo
        {
            //notare che le tre proprietà sono definite "public"
            public string Id { get; set; }
            public string Descrizione { get { return Id + " " + Marca + " " + Modello  + " " + Cilindrata + " " + nRuote; } }

            public string Marca { get; set; }
            public string Modello { get; set; }

            public int Cilindrata { get; set; }
            public int nRuote { get; set; }

            public void Stampa()
            {
                Console.WriteLine("Macchina");
            }
        }

        public class Aereo : IVeicolo
        {
            public string Id { get; set; }
            public int nRuote { get; set; }
            public string Descrizione { get { return Id + " " + Marca + " " + Modello + " " + Cilindrata + " " + nRuote; } }

            public string Marca { get; set; }
            public string Modello { get; set; }
            public int Cilindrata { get; set; }

            public void Stampa()
            {
                Console.WriteLine("Aereo");
            }

        }


    }
}
