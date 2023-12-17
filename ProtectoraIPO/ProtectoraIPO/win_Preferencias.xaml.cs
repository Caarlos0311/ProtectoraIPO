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
using System.Windows.Shapes;

namespace ProtectoraIPO
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class win_Preferencias : Window
    {
        private Preferencia preferencias;

        public win_Preferencias()
        {
            InitializeComponent();
            preferencias = MainWindow.PConfig;
            cargarValores();
        }

        private void cargarValores()
        {
            switch (preferencias.TBotones)
            {
                case 0:
                    sml_tBotones.backS.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case 1:
                    sml_tBotones.backM.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case 2:
                    sml_tBotones.backL.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
            }

            switch (preferencias.TFuentes)
            {
                case 0:
                    sml_tFuente.backS.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case 1:
                    sml_tFuente.backM.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case 2:
                    sml_tFuente.backL.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
            }

            if (preferencias.Tema)
            {
                tbtn_tema.cambiar();
            }

            if (preferencias.Gif)
            {
                tbtn_gifs.cambiar();
            }

            if (preferencias.Sonidos)
            {
                tbtn_sonidos.cambiar();
            }
        }

        internal Preferencia Preferencias { get => preferencias; set => preferencias = value; }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.b_config_L.IsEnabled = true;
            Win_Control.b_config_C.IsEnabled = true;
        }

        private void btn_aplicar_Click(object sender, RoutedEventArgs e)
        {

            Preferencia pActual = new Preferencia(false, sml_tBotones.estado, sml_tFuente.estado, -1, tbtn_tema.Toggled, tbtn_gifs.Toggled, tbtn_sonidos.Toggled);
            MainWindow.PConfig = pActual;
            aplicarCambios();

            this.Close();
        }

        public static void aplicarCambios()
        {
            //colores
            SolidColorBrush fondo;
            SolidColorBrush fondoSecundario;
            SolidColorBrush fondoTerciario;
            SolidColorBrush texto;
            SolidColorBrush textoSecundario;
            SolidColorBrush borde;
            SolidColorBrush principal;

            if (MainWindow.PConfig.Tema)
            {
                fondo = (SolidColorBrush)Application.Current.Resources["fondoClaro"];
                fondoSecundario = (SolidColorBrush)Application.Current.Resources["fondoSecundarioClaro"];
                fondoTerciario = (SolidColorBrush)Application.Current.Resources["fondoTerciarioClaro"];
                texto = (SolidColorBrush)Application.Current.Resources["textoClaro"];
                textoSecundario = (SolidColorBrush)Application.Current.Resources["textoSecundarioClaro"];
                borde = (SolidColorBrush)Application.Current.Resources["bordeClaro"];
                principal = (SolidColorBrush)Application.Current.Resources["principalClaro"];

                //tabControl gestion
                Win_Control.tc_gest.Style = (Style)Application.Current.Resources["TabControlClaroStyle"];
                foreach (TabItem ti in Win_Control.tc_gest.Items)
                {
                    ti.Style = (Style)Application.Current.Resources["TabItemClaroStyle"];
                }
                Win_Control.b_tc.Background = fondoTerciario;
                //tabcontrol ayuda
                win_Ayuda.tc_ayudaG.Style = (Style)Application.Current.Resources["TabControlClaroStyle"];
                foreach (TabItem ti in win_Ayuda.tc_ayudaG.Items)
                {
                    ti.Style = (Style)Application.Current.Resources["TabItemClaroStyle"];
                }
            }
            else
            {
                fondo = (SolidColorBrush)Application.Current.Resources["fondoOscuro"];
                fondoSecundario = (SolidColorBrush)Application.Current.Resources["fondoSecundarioOscuro"];
                fondoTerciario = (SolidColorBrush)Application.Current.Resources["fondoTerciarioOscuro"];
                texto = (SolidColorBrush)Application.Current.Resources["textoOscuro"];
                textoSecundario = (SolidColorBrush)Application.Current.Resources["textoSecundarioOscuro"];
                borde = (SolidColorBrush)Application.Current.Resources["bordeOscuro"];
                principal = (SolidColorBrush)Application.Current.Resources["principalOscuro"];

                //tabControl gestion
                Win_Control.tc_gest.Style = (Style)Application.Current.Resources["TabControlOscuroStyle"];
                foreach (TabItem ti in Win_Control.tc_gest.Items)
                {
                    ti.Style = (Style)Application.Current.Resources["TabItemOscuroStyle"];
                }
                Win_Control.b_tc.Background = fondoSecundario;
                //tabcontrol ayuda
                win_Ayuda.tc_ayudaG.Style = (Style)Application.Current.Resources["TabControlOscuroStyle"];
                foreach (TabItem ti in win_Ayuda.tc_ayudaG.Items)
                {
                    ti.Style = (Style)Application.Current.Resources["TabItemOscuroStyle"];
                }
            }
            double tamFuente = 12.0;
            switch (MainWindow.PConfig.TFuentes)
            {
                case 1:
                    tamFuente = 15.0;
                    break;
                case 2:
                    tamFuente = 18.0;
                    break;
            }

            double tamBotones = 30.0;
            double tamIconos = 25.0;
            switch (MainWindow.PConfig.TBotones)
            {
                case 1:
                    tamBotones = 35.0;
                    tamIconos = 30.0;
                    break;
                case 2:
                    tamBotones = 40.0;
                    tamIconos = 35.0;
                    break;
            }

            definirEstiloLabels(tamFuente, texto);
            definirEstiloTextBox(tamFuente, texto, fondo, borde);
            definirEstiloPasswordBox(tamFuente, texto, fondo, borde);
            definirEstiloTextBlock(tamFuente, texto);
            definirEstiloGroupBox(tamFuente, fondoSecundario, texto, borde);
            definirEstiloExpander(tamFuente, texto);
            definirEstiloListBox(tamFuente, fondoSecundario, texto, borde);
            definirEstiloMenuItem(tamFuente, fondoSecundario, texto);
            definirEstiloGridSplitter(tamFuente, borde, texto);
            definirEstiloDataGridCell(tamFuente, fondoSecundario, texto, borde);
            definirEstiloDataGrid(tamFuente, fondoSecundario, principal);
            definirEstiloDatePicker(tamFuente, fondo, borde);
            definirEstiloComboBox(fondo, fondoSecundario, texto, borde);
            definirEstiloComboBoxItem(tamFuente, fondo, texto);
            definirEstiloBotones(tamBotones, tamIconos);
            //gifs
            if (MainWindow.PConfig.Gif)
            {
                MainWindow.gif.Visibility = Visibility.Visible;
                MainWindow.nogif.Visibility = Visibility.Collapsed;
                Win_Control.gif.Visibility = Visibility.Visible;
                Win_Control.nogif.Visibility = Visibility.Collapsed;
            }
            else
            {
                MainWindow.gif.Visibility = Visibility.Collapsed;
                MainWindow.nogif.Visibility = Visibility.Visible;
                Win_Control.gif.Visibility = Visibility.Collapsed;
                Win_Control.nogif.Visibility = Visibility.Visible;
            }
        }

        private static void definirEstiloPasswordBox(double tamFuente, SolidColorBrush colorTexto, SolidColorBrush colorFondo, SolidColorBrush colorBorde)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(PasswordBox.BackgroundProperty, colorFondo));
            styleP.Setters.Add(new Setter(PasswordBox.ForegroundProperty, colorTexto));
            styleP.Setters.Add(new Setter(PasswordBox.BorderBrushProperty, colorBorde));
            styleP.Setters.Add(new Setter(PasswordBox.FontSizeProperty, tamFuente));
            styleP.Setters.Add(new Setter(PasswordBox.VerticalContentAlignmentProperty, VerticalAlignment.Center));
            styleP.Setters.Add(new Setter(PasswordBox.PaddingProperty, new Thickness(0, 0, 0, 0)));

            Application.Current.Resources["PasswordBoxStyle"] = styleP;
        }

        private static void definirEstiloBotones(double tamBotones, double tamIconos)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.Transparent));
            styleP.Setters.Add(new Setter(Button.BorderThicknessProperty, new Thickness(0, 0, 0, 0)));
            styleP.Setters.Add(new Setter(Button.BorderBrushProperty, Brushes.Transparent));
            styleP.Setters.Add(new Setter(Button.VerticalAlignmentProperty, VerticalAlignment.Center));
            styleP.Setters.Add(new Setter(Button.WidthProperty, tamBotones));
            styleP.Setters.Add(new Setter(Button.HeightProperty, tamBotones));
            styleP.Setters.Add(new Setter(Button.MarginProperty, new Thickness(5, 0, 5, 0)));
            styleP.Setters.Add(new Setter(Button.CursorProperty, Cursors.Hand));

            Application.Current.Resources["ButtonStyle"] = styleP;

            styleP = new Style();
            styleP.Setters.Add(new Setter(Image.WidthProperty, tamIconos));
            styleP.Setters.Add(new Setter(Image.HeightProperty, tamIconos));

            Application.Current.Resources["ImageStyle"] = styleP;
        }

        private static void definirEstiloComboBoxItem(double tamFuente, SolidColorBrush colorFondo, SolidColorBrush colorTexto)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(ComboBoxItem.BackgroundProperty, colorFondo));
            styleP.Setters.Add(new Setter(ComboBoxItem.ForegroundProperty, colorTexto));
            styleP.Setters.Add(new Setter(ComboBoxItem.FontSizeProperty, tamFuente));

            Application.Current.Resources["ComboBoxItemStyle"] = styleP;
        }

        private static void definirEstiloComboBox(SolidColorBrush fondo, SolidColorBrush fondoSecundario, SolidColorBrush texto, SolidColorBrush borde)
        {
            Application.Current.Resources["fondoComboBox"] = fondo;
            Application.Current.Resources["fondoSecundarioComboBox"] = fondoSecundario;
            Application.Current.Resources["textoComboBox"] = texto;
            Application.Current.Resources["bordeComboBox"] = borde;
        }

        private static void definirEstiloDatePicker(double tamFuente, SolidColorBrush colorFondo, SolidColorBrush colorBorde)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(DatePicker.BackgroundProperty, colorFondo));
            styleP.Setters.Add(new Setter(DatePicker.ForegroundProperty, (SolidColorBrush)Application.Current.Resources["textoClaro"]));
            styleP.Setters.Add(new Setter(DatePicker.BorderBrushProperty, colorBorde));
            styleP.Setters.Add(new Setter(DatePicker.FontSizeProperty, tamFuente));
            styleP.Setters.Add(new Setter(DatePicker.VerticalContentAlignmentProperty, VerticalAlignment.Center));

            Application.Current.Resources["DatePickerStyle"] = styleP;
        }

        private static void definirEstiloDataGrid(double tamFuente, SolidColorBrush colorFondo, SolidColorBrush colorBorde)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(DataGrid.BackgroundProperty, colorFondo));
            styleP.Setters.Add(new Setter(DataGrid.BorderBrushProperty, colorBorde));
            styleP.Setters.Add(new Setter(DataGrid.FontSizeProperty, tamFuente));
            styleP.Setters.Add(new Setter(DataGrid.VerticalContentAlignmentProperty, VerticalAlignment.Center));

            Application.Current.Resources["DataGridStyle"] = styleP;
        }

        private static void definirEstiloDataGridCell(double tamFuente, SolidColorBrush colorFondo, SolidColorBrush colorTexto, SolidColorBrush colorBorde)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(DataGridCell.BackgroundProperty, colorFondo));
            styleP.Setters.Add(new Setter(DataGridCell.BorderBrushProperty, colorBorde));
            styleP.Setters.Add(new Setter(DataGridCell.ForegroundProperty, colorTexto));

            Application.Current.Resources["DataGridCellStyle"] = styleP;
        }

        private static void definirEstiloGridSplitter(double tamFuente, SolidColorBrush colorFondo, SolidColorBrush colorTexto)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(GridSplitter.BackgroundProperty, colorFondo));
            styleP.Setters.Add(new Setter(GridSplitter.WidthProperty, 5.0));
            styleP.Setters.Add(new Setter(GridSplitter.HorizontalAlignmentProperty, HorizontalAlignment.Stretch));

            Application.Current.Resources["GridSplitterStyle"] = styleP;
        }

        private static void definirEstiloMenuItem(double tamFuente, SolidColorBrush colorFondo, SolidColorBrush colorTexto)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(MenuItem.BackgroundProperty, colorFondo));
            styleP.Setters.Add(new Setter(MenuItem.ForegroundProperty, colorTexto));
            styleP.Setters.Add(new Setter(MenuItem.FontSizeProperty, tamFuente));
            styleP.Setters.Add(new Setter(MenuItem.VerticalContentAlignmentProperty, VerticalAlignment.Center));

            Application.Current.Resources["MenuItemStyle"] = styleP;
        }

        private static void definirEstiloListBox(double tamFuente, SolidColorBrush colorFondo, SolidColorBrush colorTexto, SolidColorBrush colorBorde)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(ListBox.BackgroundProperty, colorFondo));
            styleP.Setters.Add(new Setter(ListBox.ForegroundProperty, colorTexto));
            styleP.Setters.Add(new Setter(ListBox.BorderBrushProperty, colorBorde));
            styleP.Setters.Add(new Setter(ListBox.FontSizeProperty, tamFuente));
            styleP.Setters.Add(new Setter(ListBox.VerticalContentAlignmentProperty, VerticalAlignment.Center));

            Application.Current.Resources["ListBoxStyle"] = styleP;
        }

        private static void definirEstiloExpander(double tamFuente, SolidColorBrush colorTexto)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(Expander.ForegroundProperty, colorTexto));
            styleP.Setters.Add(new Setter(Expander.FontSizeProperty, tamFuente));

            Application.Current.Resources["ExpanderStyle"] = styleP;
        }

        private static void definirEstiloGroupBox(double tamFuente, SolidColorBrush colorFondo, SolidColorBrush colorTexto, SolidColorBrush colorBorde)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(GroupBox.BackgroundProperty, colorFondo));
            styleP.Setters.Add(new Setter(GroupBox.ForegroundProperty, colorTexto));
            styleP.Setters.Add(new Setter(GroupBox.BorderBrushProperty, colorBorde));
            styleP.Setters.Add(new Setter(GroupBox.FontSizeProperty, tamFuente));
            Application.Current.Resources["GroupBoxStyle"] = styleP;
        }

        private static void definirEstiloTextBlock(double tamFuente, SolidColorBrush colorTexto)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(TextBlock.ForegroundProperty, colorTexto));
            styleP.Setters.Add(new Setter(TextBlock.FontSizeProperty, tamFuente));
            styleP.Setters.Add(new Setter(TextBlock.VerticalAlignmentProperty, VerticalAlignment.Center));
            styleP.Setters.Add(new Setter(TextBlock.PaddingProperty, new Thickness(0, 0, 0, 0)));

            Application.Current.Resources["TextBlockStyle"] = styleP;
        }

        private static void definirEstiloTextBox(double tamFuente, SolidColorBrush colorTexto, SolidColorBrush colorFondo, SolidColorBrush colorBorde)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(TextBox.BackgroundProperty, colorFondo));
            styleP.Setters.Add(new Setter(TextBox.ForegroundProperty, colorTexto));
            styleP.Setters.Add(new Setter(TextBox.BorderBrushProperty, colorBorde));
            styleP.Setters.Add(new Setter(TextBox.FontSizeProperty, tamFuente));
            styleP.Setters.Add(new Setter(TextBox.VerticalContentAlignmentProperty, VerticalAlignment.Center));
            styleP.Setters.Add(new Setter(TextBox.PaddingProperty, new Thickness(0, 0, 0, 0)));

            Application.Current.Resources["TextBoxStyle"] = styleP;
        }

        private static void definirEstiloLabels(double tamFuente, SolidColorBrush colorTexto)
        {
            Style styleP = new Style();
            styleP.Setters.Add(new Setter(Label.ForegroundProperty, colorTexto));
            styleP.Setters.Add(new Setter(Label.FontSizeProperty, tamFuente));
            styleP.Setters.Add(new Setter(Label.VerticalContentAlignmentProperty, VerticalAlignment.Center));
            styleP.Setters.Add(new Setter(Label.PaddingProperty, new Thickness(0, 0, 0, 0)));

            Application.Current.Resources["LabelStyle"] = styleP;
        }
    }



}
