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
    public partial class SML_switch : UserControl
    {
        public Button s;
        public Button m;
        public Button l;

        SolidColorBrush off = new SolidColorBrush(Color.FromRgb(160, 160, 160));
        //SolidColorBrush on = new SolidColorBrush(Color.FromRgb(35, 180, 200));
        SolidColorBrush on = new SolidColorBrush(Color.FromRgb(255, 171, 108));
        
        public int estado = 0;
        public SML_switch()
        {
            InitializeComponent();
            s = backS;
            m = backM;
            l = backL;
            estado = 0;
            backS.Background = on;
            backM.Background = off;
            backL.Background = off;
        }

        public void backS_Click(object sender, RoutedEventArgs e)
        {
            if (estado != 0) {
                estado = 0;
                backS.Background = on;
                backM.Background = off;
                backL.Background = off;
            }
        }

        public void backM_Click(object sender, RoutedEventArgs e)
        {
            if (estado != 1)
            {
                estado = 1;
                backS.Background = off;
                backM.Background = on;
                backL.Background = off;
            }
        }

        public void backL_Click(object sender, RoutedEventArgs e)
        {
            if (estado != 2)
            {
                estado = 2;
                backS.Background = off;
                backM.Background = off;
                backL.Background = on;
            }
        }
    }
}
