using ProtectoraIPO.Clases;
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

namespace ProtectoraIPO.Paginas
{
    /// <summary>
    /// Lógica de interacción para pg_listaAyudas.xaml
    /// </summary>
    public partial class pg_listaAyudas : Page
    {
        private List<Ayuda> ayds;
        public pg_listaAyudas(List<Ayuda> ayds)
        {
            InitializeComponent();
            Ayds = ayds;
            List<Ayuda> listAux = new List<Ayuda>();
            foreach (Ayuda aAux in ayds) {
                listAux.Add(aAux);
            }
            lb_ayuda.ItemsSource = listAux;
            
        }

        public List<Ayuda> Ayds { get => ayds; set => ayds = value; }

        private void lb_ayuda_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new pg_ayudaDesc(ayds, lb_ayuda.SelectedIndex));
        }
    }
}
