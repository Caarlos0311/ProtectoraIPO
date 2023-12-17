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
    /// Lógica de interacción para pg_ayudaDesc.xaml
    /// </summary>
    public partial class pg_ayudaDesc : Page
    {
        private List<Ayuda> ayds;
        private Ayuda ayudaSel;
        public pg_ayudaDesc(List<Ayuda> ayds, int id)
        {
            InitializeComponent();
            Ayds = ayds;
            ayudaSel = ayds.ElementAt(id);
            cargarAyuda();
        }

        private void cargarAyuda()
        {
            //cargar titulo
            lbl_titulo.Content = ayudaSel.Titulo;
            //cargar nPasos
            for(int i=1; i< ayudaSel.Pasos.Length; i++) {
                RadioButton r = new RadioButton();
                r.Name = "RB_" + i;
                r.Click += RB_Click;
                r.Content = i+1;
                sp_pasos.Children.Add(r);
            }
            //cargar paso 1
            RB_0.IsChecked = true;
            txt_descripcion.Text = ayudaSel.Pasos.ElementAt(0).Descripcion;
            //cargar foto
            var bitmap = new BitmapImage(ayudaSel.Pasos[0].Foto);
            img_foto.Source = bitmap;
        }

        public List<Ayuda> Ayds { get => ayds; set => ayds = value; }

        private void btn_atrasDesc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pg_listaAyudas(ayds));
        }

        private void RB_Click(object sender, RoutedEventArgs e)
        {
            RadioButton r = e.Source as RadioButton;
            string nombre = r.Name;
            string id = nombre.Substring(3);
            int sel = int.Parse(id);

            txt_descripcion.Text = ayudaSel.Pasos.ElementAt(sel).Descripcion;
            //cambiar foto
            var bitmap = new BitmapImage(ayudaSel.Pasos[sel].Foto);
            img_foto.Source = bitmap;
        }
    }
}
