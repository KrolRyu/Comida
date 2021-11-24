using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public MainWindowVM()
        {
            Tipos = new List<string> {"China","Americana","Mexicana"};
            Comidas = Plato.GetSamples("img/");
        }
        private Plato platoEscogido;

        public Plato PlatoEscogido
        {
            get { return platoEscogido; }
            set 
            { 
                platoEscogido = value;
                NotifyPropertyChanged("PlatoEscogido");
            }
        }

        private List<string> tipos;

        public List<string> Tipos
        {
            get { return tipos; }
            set
            {
                tipos = value;
                NotifyPropertyChanged("Tipos");
            }
        }
        private ObservableCollection<Plato> comidas;

        public ObservableCollection<Plato> Comidas
        {
            get { return comidas; }
            set { 
                comidas = value;
                NotifyPropertyChanged("Comidas");
            }
        }

        private Plato platoSeleccionado;

        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set { 
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        public void Limpiar()
        {
            PlatoEscogido = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
