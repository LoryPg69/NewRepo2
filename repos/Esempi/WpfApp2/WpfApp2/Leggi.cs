using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace WpfApp2
{
    public class Leggi : INotifyPropertyChanged
    {
        private ObservableCollection<Banche> _banche = new ObservableCollection<Banche>();
        public ObservableCollection<Banche> Banca { get { return _banche; } set { _banche = value; } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void CaricaDati()
        {
            Banca = Banche();
        }


     private ObservableCollection<Banche> Banche()
        {
            ObservableCollection<Banche> Cli = new ObservableCollection<Banche>();
        
           //using (Bankomat2Entities dc = new Bankomat2Entities)
           //         {
           //         List<Banche> lb = (from c in dc.Banche select c).ToList();
           //             Cli = new ObservableCollection<Banche>(lb);

        try
            {
                using (Bankomat2Entities1 dc = new Bankomat2Entities1())
                {
                    List<Banche> lb = (from c in dc.Banche select c).ToList();
                    Cli = new ObservableCollection<Banche>(lb);
                }
            }
            catch
            {
            }
            return Cli;

        }

        protected void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        }

}
    
   
            
            


    

        
        
    
