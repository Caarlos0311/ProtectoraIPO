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

namespace ProtectoraIPO
{
    /// <summary>
    /// Lógica de interacción para ToggleButton.xaml
    /// </summary>
    public partial class ToggleButton : UserControl
    {
        Thickness leftSide = new Thickness(-39, 0, 0, 0);
        Thickness rightSide = new Thickness(0, 0, -39, 0);
        SolidColorBrush off = new SolidColorBrush(Color.FromRgb(160, 160, 160));
        //SolidColorBrush on = new SolidColorBrush(Color.FromRgb(35, 180, 200));
        SolidColorBrush on = new SolidColorBrush(Color.FromRgb(255, 171, 108));
        private bool toggled = false;
        public ToggleButton()
        {
            InitializeComponent();
            back.Fill = off;
            Toggled = false;
            dot.Margin = leftSide;
        }

        public bool Toggled { get => toggled; set => toggled = value; }

        public void dot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            cambiar();
        }

        public void back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            cambiar();
            
        }

        public void cambiar() {
            if (!Toggled)
            {
                back.Fill = on;
                Toggled = true;
                dot.Margin = rightSide;
            }
            else
            {
                back.Fill = off;
                Toggled = false;
                dot.Margin = leftSide;
            }
        }

        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = false;
        }
    }
}
