using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Persone persone;
            //Persone persone2;
            //Persone clona;

            //    persone = new Persone();
            //    persone2 = new Persone();
            //    clona = new Persone();

            //    InitializeComponent();

            //    persone.nome = "Lorenzo";
            //    persone.cognome = "Pioggia";

            //    persone2.nome = "yfr";
            //    persone2.cognome = "yy";

            //    txtCognome.Text = persone.cognome;
            //    txtNome.Text = persone.nome;

            //(Db)this.DataContext).CaricaDati();

        }

        private void btnChiudi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();    //this --> distinque le classi in altre funzioni che magari hanno lo stesso nome
        }
        private void DataGrid_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
