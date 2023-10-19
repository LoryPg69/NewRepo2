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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Persone persone;
        Persone persone2;
        Persone clona;
        public MainWindow()
        {
            persone = new Persone();
            persone2 = new Persone();
            clona = new Persone();

            InitializeComponent();

            persone.nome = "Lorenzo";
            persone.cognome = "Pioggia";

            persone2.nome = "Sara";
            persone2.cognome = "Mitler";

            txtCognome.Text = persone.cognome;
            txtNome.Text = persone.nome;          

            persone2 = clona;


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnChiudi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();                //this --> distinque le classi in altre funzioni che magari hanno lo stesso nome
                                                    
        }
    }
}
