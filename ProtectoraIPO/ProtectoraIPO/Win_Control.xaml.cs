using Microsoft.Win32;
using ProtectoraIPO.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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
    /// Lógica de interacción para Win_Control.xaml
    /// </summary>
    public partial class Win_Control : Window
    {
        //componentes
        public static Button b_config_C;
        public static Button b_ayuda_C;
        private MainWindow MW;
        private string accion;
        private Uri imgDefecto;

        public static Image gif;
        public static Image nogif;

        public static TabControl tc_gest;
        public static Border b_tc;

        //comboBox
        public static ComboBox cbx_sexo_p;
        public static ComboBox cbx_padrinos_p;
        public static ComboBox cbx_estado_p;
        //padrinos
        public static ComboBox cbx_formaPago_pa;
        //socios
        public static ComboBox cbx_formaPago_so;
        //listas
        public static ComboBox cbx_lista;

        //labels
        public static Label nombreUsuario;
        public static Label apellidosUsuario;
        public static Label ultimoInicio;


        public Win_Control(MainWindow mw)
        {
            InitializeComponent();
            //label
            nombreUsuario = lbl_nombre_is;
            apellidosUsuario = lbl_apellidos_is;
            ultimoInicio = lbl_ultimoInicio_is;

            //combobox
            cbx_sexo_p = cb_sexo_wc;
            cbx_padrinos_p = cb_padrinos_wc;
            cbx_estado_p = cb_estado_wc;
            //padrinos
            cbx_formaPago_pa = cb_formaPago_pa;
            //socios
            cbx_formaPago_so = cb_formaPago_so;
            //listas
            cbx_lista = cb_lista;



            tc_gest = tc_gestion;
            b_tc = b_tabControl;
            gif = gif_control;
            nogif = nogif_control;
            MW = mw;
            b_ayuda_C = btn_ayuda_c;
            b_config_C = btn_config_c;
            imgDefecto = new Uri("Fotos/IMG_Ejemplo.jpg", UriKind.Relative);

            //perros
            lb_perros.ItemsSource = MainWindow.Perros;
            lb_perros.SelectedIndex = 0;
            cb_padrinos_wc.ItemsSource = MainWindow.Padrinos;

            //padrinos
            lb_padrinos.ItemsSource = MainWindow.Padrinos;
            lb_padrinos.SelectedIndex = 0;

            //socios
            lb_socios.ItemsSource = MainWindow.Socios;
            lb_socios.SelectedIndex = 0;

            //voluntarios
            lb_voluntarios.ItemsSource = MainWindow.Voluntarios;
            lb_voluntarios.SelectedIndex = 0;

            //listas
            dg_perros.ItemsSource = MainWindow.Perros;
            dg_padrinos.ItemsSource = MainWindow.Padrinos;
            dg_socios.ItemsSource = MainWindow.Socios;
            dg_voluntarios.ItemsSource = MainWindow.Voluntarios;
            cb_lista.SelectedIndex = 0;
            dg_perros.Visibility = Visibility.Visible;
        }

        private void btn_config_Click(object sender, RoutedEventArgs e)
        {
            win_Preferencias winPref = new win_Preferencias();
            winPref.Show();
            btn_config_c.IsEnabled = false;
            MainWindow.b_config_L.IsEnabled = false;
        }

        private void btn_ayuda_Click(object sender, RoutedEventArgs e)
        {
            win_Ayuda winAyu = new win_Ayuda(MainWindow.Ayudas);
            win_Preferencias.aplicarCambios();
            winAyu.Show();
            btn_ayuda_c.IsEnabled = false;
            MainWindow.b_ayuda_L.IsEnabled = false;
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.PConfig.Sonidos)
            {
                //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/llanto_3seg.wav");
                //miSonido3.Play();
                SystemSounds.Hand.Play();
            }

            if (g_accion.Visibility == Visibility.Visible || g_accion_pa.Visibility == Visibility.Visible || g_accion_so.Visibility == Visibility.Visible || g_accion_vo.Visibility == Visibility.Visible)
            {
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar la sesión sin terminar la acción?", "Confirmación", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        this.Visibility = Visibility.Collapsed;
                        MW.mostrarLogin();
                        MW.Show();

                        MessageBox.Show("Hasta luego " + MainWindow.aAux.Nombre, "Cerrando Sesión");
                        MainWindow.aAux.UltimoAcceso = DateTime.Now;
                        break;
                }
            }
            else
            {
                this.Visibility = Visibility.Collapsed;
                MW.mostrarLogin();
                MW.Show();

                MessageBox.Show("Hasta luego " + MainWindow.aAux.Nombre, "Cerrando Sesión");
                MainWindow.aAux.UltimoAcceso = DateTime.Now;
            }
        }

        private void lb_perros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Perro pSel = lb_perros.SelectedItem as Perro;
            //cb_padrinos_wc.SelectedIndex= pSel.Padr
            if (pSel != null)
            {
                if (MainWindow.PConfig.Sonidos)
                {
                    //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                    //miSonido3.Play();
                    SystemSounds.Hand.Play();
                }
                //cargarImagen
                var bitmap = new BitmapImage(pSel.Foto);
                img_foto_pe.Source = bitmap;

                txt_nombre_wc.Text = pSel.Nombre;
                txt_edad_wc.Text = pSel.Edad.ToString();
                txt_peso_wc.Text = pSel.Peso.ToString();
                cb_sexo_wc.SelectedIndex = pSel.Sexo;
                txt_raza_wc.Text = pSel.Raza;
                txt_descripcion_wc.Text = pSel.Descripcion;
                txt_chip_wc.Text = pSel.Chip;
                dp_fechaEntrada_wc.SelectedDate = pSel.FechaEntrada;
                cb_estado_wc.SelectedIndex = pSel.Estado;
                txt_enfermedades.Text = pSel.Enfermedades;

                if (tbtn_sociable_wc.Toggled != pSel.Sociable)
                {
                    tbtn_sociable_wc.cambiar();
                }
                if (tbtn_sociable_wc.Toggled)
                {
                    lbl_sociable_p.Content = "Es sociable";
                }
                else
                {
                    lbl_sociable_p.Content = "No es sociable";
                }
                if (tbtn_ppp_wc.Toggled != pSel.Ppp)
                {
                    tbtn_ppp_wc.cambiar();
                }
                if (tbtn_ppp_wc.Toggled)
                {
                    lbl_ppp_p.Content = "Es ppp";
                }
                else
                {
                    lbl_ppp_p.Content = "No es ppp";
                }
                if (tbtn_vacunado_wc.Toggled != pSel.Vacunado)
                {
                    tbtn_vacunado_wc.cambiar();
                }
                if (tbtn_vacunado_wc.Toggled)
                {
                    lbl_vacunado_p.Content = "Está vacunado";
                }
                else
                {
                    lbl_vacunado_p.Content = "No está vacunado";
                }
                if (tbtn_esterilizado_wc.Toggled != pSel.Esterilizado)
                {
                    tbtn_esterilizado_wc.cambiar();
                }
                if (tbtn_esterilizado_wc.Toggled)
                {
                    lbl_esterilizado_p.Content = "Está esterilizado";
                }
                else
                {
                    lbl_esterilizado_p.Content = "No está esterilizado";
                }
                cb_padrinos_wc.SelectedIndex = seleccionarItem(pSel.Padr);
            }
            else
            {
                lb_perros.SelectedIndex = 0;
            }
        }

        private int seleccionarItem(Padrino padr)
        {
            int i = -1;
            if (padr != null)
            {
                foreach (Padrino p in cb_padrinos_wc.Items)
                {
                    i++;
                    if (p.Nombre.Equals(padr.Nombre) && p.Apellidos.Equals(padr.Apellidos))
                    {
                        return i;
                    }
                }
            }
            return i;
        }

        private void mi_delPerros_Click(object sender, RoutedEventArgs e)
        {
            if (lb_perros.Items.Count != 0)
            {
                if (MainWindow.PConfig.Sonidos)
                {
                    //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/llanto_3seg.wav");
                    //miSonido3.Play();
                    SystemSounds.Hand.Play();
                }
                Perro pAux = lb_perros.SelectedItem as Perro;
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que quieres borrar a " + pAux.Nombre + "?", "Confirmación", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        MainWindow.Perros.Remove(pAux);
                        lb_perros.ItemsSource = null;
                        lb_perros.ItemsSource = MainWindow.Perros;
                        MessageBox.Show("Eliminación exitosa.", "Perro borrado");
                        break;
                }
                if (MainWindow.Perros.Count == 0)
                {
                    vaciarCamposPerro();
                }
            }
            else
            {
                MessageBox.Show("No hay un perro para borrar.", "Lista vacia");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MainWindow.PConfig.Sonidos)
            {
                //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/llanto_3seg.wav");
                //miSonido3.Play();
                SystemSounds.Hand.Play();
            }

            if (g_accion.Visibility == Visibility.Visible || g_accion_pa.Visibility == Visibility.Visible || g_accion_so.Visibility == Visibility.Visible || g_accion_vo.Visibility == Visibility.Visible)
            {
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación sin terminar la acción?", "Confirmación", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        MainWindow.aAux.UltimoAcceso = DateTime.Now;
                        MainWindow.guardar();
                        MessageBox.Show("Hasta luego " + MainWindow.aAux.Nombre, "Cerrando la aplicación");
                        Application.Current.Shutdown();
                        break;
                    case MessageBoxResult.No:
                        e.Cancel = true;
                        break;
                }
            }
            else
            {
                if (MainWindow.aAux != null)
                {
                    MainWindow.aAux.UltimoAcceso = DateTime.Now;
                }

                MainWindow.guardar();
                MessageBox.Show("Hasta luego", "Cerrando la aplicación");

                Application.Current.Shutdown();
            }
        }

        private void mi_udtPerros_Click(object sender, RoutedEventArgs e)
        {
            if (lb_perros.Items.Count != 0)
            {
                accion = "Actualizar";
                //mostrar botones aceptar cancelar
                lbl_accionRealizar_pe.Content = accion;
                g_accion.Visibility = Visibility.Visible;
                glb_perros.Visibility = Visibility.Collapsed;
                gs_perros.Visibility = Visibility.Collapsed;
                //desbloquear campos
                activarCampos(true);
                //bloquear navegacion
                ti_padrinos.IsEnabled = false;
                ti_socios.IsEnabled = false;
                ti_voluntarios.IsEnabled = false;
                ti_listas.IsEnabled = false;

                sp_botones_pe.IsEnabled = false;
                btn_verPadrino.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("No hay un perro para actualizar.", "Lista vacia");
            }
        }

        private void mi_addPerros_Click(object sender, RoutedEventArgs e)
        {
            accion = "Añadir";
            //mostrar botones aceptar cancelar
            lbl_accionRealizar_pe.Content = accion;
            g_accion.Visibility = Visibility.Visible;
            glb_perros.Visibility = Visibility.Collapsed;
            gs_perros.Visibility = Visibility.Collapsed;
            //vaciar campos
            lb_perros.SelectedItem = null;

            vaciarCamposPerro();
            activarCampos(true);

            //bloquear navegacion
            ti_padrinos.IsEnabled = false;
            ti_socios.IsEnabled = false;
            ti_voluntarios.IsEnabled = false;
            ti_listas.IsEnabled = false;

            sp_botones_pe.IsEnabled = false;
            btn_verPadrino.IsEnabled = false;
        }

        private void activarCampos(bool v)
        {
            txt_nombre_wc.IsEnabled = v;
            cb_sexo_wc.IsEnabled = v;
            txt_edad_wc.IsEnabled = v;
            txt_peso_wc.IsEnabled = v;
            txt_raza_wc.IsEnabled = v;
            tbtn_sociable_wc.IsEnabled = v;
            tbtn_ppp_wc.IsEnabled = v;
            txt_descripcion_wc.IsEnabled = v;
            btn_QuitarPadrino.IsEnabled = v;
            cb_padrinos_wc.IsEnabled = v;
            txt_chip_wc.IsEnabled = v;
            dp_fechaEntrada_wc.IsEnabled = v;
            cb_estado_wc.IsEnabled = v;
            txt_enfermedades.IsEnabled = v;
            tbtn_vacunado_wc.IsEnabled = v;
            tbtn_esterilizado_wc.IsEnabled = v;
            btn_cargarImg.IsEnabled = v;
        }

        private void vaciarCamposPerro()
        {
            var bitmap = new BitmapImage(imgDefecto);
            img_foto_pe.Source = bitmap;

            txt_nombre_wc.Text = "";
            cb_sexo_wc.SelectedIndex = 0;
            txt_edad_wc.Text = "";
            txt_peso_wc.Text = "";
            txt_raza_wc.Text = "";
            if (tbtn_sociable_wc.Toggled)
            {
                tbtn_sociable_wc.cambiar();
            }
            if (tbtn_ppp_wc.Toggled)
            {
                tbtn_ppp_wc.cambiar();
            }
            txt_descripcion_wc.Text = "";
            cb_padrinos_wc.SelectedIndex = -1;
            txt_chip_wc.Text = "No posee";
            dp_fechaEntrada_wc.SelectedDate = null;
            cb_estado_wc.SelectedIndex = 4;
            txt_enfermedades.Text = "";
            if (tbtn_vacunado_wc.Toggled)
            {
                tbtn_vacunado_wc.cambiar();
            }
            if (tbtn_esterilizado_wc.Toggled)
            {
                tbtn_esterilizado_wc.cambiar();
            }
        }

        private void btn_aceptar_p_Click(object sender, RoutedEventArgs e)
        {
            if (accion.Equals("Actualizar"))
            {
                //comprobarActualizar
                if (comprobarCeldas())
                {
                    //sonido
                    if (MainWindow.PConfig.Sonidos)
                    {
                        //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                        //miSonido3.Play();
                        SystemSounds.Hand.Play();
                    }
                    Perro pAux = lb_perros.SelectedItem as Perro;
                    pAux.Actualizar(txt_nombre_wc.Text, cb_sexo_wc.SelectedIndex, txt_raza_wc.Text, Convert.ToDouble(txt_peso_wc.Text), Convert.ToInt32(txt_edad_wc.Text), Convert.ToDateTime(dp_fechaEntrada_wc.SelectedDate), txt_chip_wc.Text, tbtn_ppp_wc.Toggled, tbtn_vacunado_wc.Toggled, tbtn_esterilizado_wc.Toggled, txt_enfermedades.Text, (img_foto_pe.Source as BitmapImage).UriSource, txt_descripcion_wc.Text, tbtn_sociable_wc.Toggled, cb_estado_wc.SelectedIndex, cb_padrinos_wc.SelectedItem as Padrino);
                    //bloquear celdas
                    activarCampos(false);
                    //quitar colores
                    quitarColores();
                    //activar listbox
                    glb_perros.Visibility = Visibility.Visible;
                    gs_perros.Visibility = Visibility.Visible;
                    //ocultar accion
                    g_accion.Visibility = Visibility.Collapsed;


                    lb_perros.ItemsSource = null;
                    lb_perros.ItemsSource = MainWindow.Perros;

                    dg_perros.ItemsSource = null;
                    dg_perros.ItemsSource = MainWindow.Perros;
                    //mensaje
                    MessageBox.Show("Actualización exitosa.", "Perro actualizado");
                    //activar navegacion
                    ti_padrinos.IsEnabled = true;
                    ti_socios.IsEnabled = true;
                    ti_voluntarios.IsEnabled = true;
                    ti_listas.IsEnabled = true;

                    sp_botones_pe.IsEnabled = true;
                    btn_verPadrino.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
                }
            }
            else
            {
                //comprobarAñadir
                if (comprobarCeldas())
                {
                    //sonido
                    if (MainWindow.PConfig.Sonidos)
                    {
                        //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                        //miSonido3.Play();
                        SystemSounds.Hand.Play();
                    }
                    Perro pAux = new Perro(txt_nombre_wc.Text, cb_sexo_wc.SelectedIndex, txt_raza_wc.Text, Convert.ToDouble(txt_peso_wc.Text), Convert.ToInt32(txt_edad_wc.Text), Convert.ToDateTime(dp_fechaEntrada_wc.SelectedDate), txt_chip_wc.Text, tbtn_ppp_wc.Toggled, tbtn_vacunado_wc.Toggled, tbtn_esterilizado_wc.Toggled, txt_enfermedades.Text, (img_foto_pe.Source as BitmapImage).UriSource, txt_descripcion_wc.Text, tbtn_sociable_wc.Toggled, cb_estado_wc.SelectedIndex, cb_padrinos_wc.SelectedItem as Padrino);
                    MainWindow.Perros.Add(pAux);
                    //bloquear celdas
                    activarCampos(false);
                    //quitar colores
                    quitarColores();
                    //activar listbox
                    glb_perros.Visibility = Visibility.Visible;
                    gs_perros.Visibility = Visibility.Visible;
                    //ocultar accion
                    g_accion.Visibility = Visibility.Collapsed;

                    lb_perros.ItemsSource = null;
                    lb_perros.ItemsSource = MainWindow.Perros;

                    dg_perros.ItemsSource = null;
                    dg_perros.ItemsSource = MainWindow.Perros;
                    //mensaje
                    MessageBox.Show("Incorporación exitosa.", "Perro añadido");
                    //activar navegacion
                    ti_padrinos.IsEnabled = true;
                    ti_socios.IsEnabled = true;
                    ti_voluntarios.IsEnabled = true;
                    ti_listas.IsEnabled = true;

                    sp_botones_pe.IsEnabled = true;
                    btn_verPadrino.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
                }
            }
        }

        private void quitarColores()
        {
            colorBase(adv_nombre_p);
            colorBase(adv_edad_p);
            colorBase(adv_peso_p);
            colorBase(adv_raza_p);
            colorBase(adv_chip_p);
            colorBase(adv_fecha_p);
        }

        private void colorBase(Image i)
        {
            i.Visibility = Visibility.Collapsed;
        }

        private bool comprobarCeldas()
        {
            bool valido = true;
            if (!MainWindow.comprobarNoVacio(txt_nombre_wc.Text, adv_nombre_p))
            {
                valido = false;
            }

            if (!MainWindow.comprobarNoVacio(txt_edad_wc.Text, adv_edad_p))
            {
                valido = false;
            }

            if (!MainWindow.comprobarNoVacio(txt_peso_wc.Text, adv_peso_p))
            {
                valido = false;
            }

            if (!MainWindow.comprobarNoVacio(txt_raza_wc.Text, adv_raza_p))
            {
                valido = false;
            }

            if (!MainWindow.comprobarNoVacio(txt_chip_wc.Text, adv_chip_p))
            {
                valido = false;
            }

            if (dp_fechaEntrada_wc.SelectedDate == null)
            {
                adv_fecha_p.Visibility = Visibility.Visible;
                valido = false;
            }
            else
            {
                adv_fecha_p.Visibility = Visibility.Collapsed;
            }

            //falta comprobar que se ha seleccionado una foto
            return valido;
        }

        private void btn_cancelar_p_Click(object sender, RoutedEventArgs e)
        {
            //bloquear celdas
            activarCampos(false);
            //quitar colores
            quitarColores();
            //activar listbox
            glb_perros.Visibility = Visibility.Visible;
            gs_perros.Visibility = Visibility.Visible;
            //ocultar accion
            g_accion.Visibility = Visibility.Collapsed;

            lb_perros.ItemsSource = null;
            lb_perros.ItemsSource = MainWindow.Perros;
            //activar navegacion
            ti_padrinos.IsEnabled = true;
            ti_socios.IsEnabled = true;
            ti_voluntarios.IsEnabled = true;
            ti_listas.IsEnabled = true;

            sp_botones_pe.IsEnabled = true;
            btn_verPadrino.IsEnabled = true;
        }

        private void cargaImg_Click(object sender, RoutedEventArgs e)
        {
            cargarImg(img_foto_pe);
        }

        private void btn_QuitarPadrino_Click(object sender, RoutedEventArgs e)
        {
            if (cb_padrinos_wc.SelectedIndex >= 0)
            {
                cb_padrinos_wc.SelectedIndex = -1;
            }
        }

        private void btn_verPadrino_Click(object sender, RoutedEventArgs e)
        {
            tc_gestion.SelectedIndex = 1;
            //mostra el socio seleccionado en el combobox
            lb_padrinos.SelectedIndex = cb_padrinos_wc.SelectedIndex;
        }

        private void NumberValidationIntTextBox(object sender, TextCompositionEventArgs e)
        {
            string textoPrevio = (sender as TextBox).Text;
            string textoSolicitado = textoPrevio + e.Text;
            int valor;
            try
            {
                valor = int.Parse(textoSolicitado);
                e.Handled = false;
            }
            catch (Exception)
            {
                e.Handled = true;
            }
        }

        private void NumberValidationDoubleTextBox(object sender, TextCompositionEventArgs e)
        {
            string textoPrevio = (sender as TextBox).Text;
            string textoSolicitado = textoPrevio + e.Text;
            double valor;
            try
            {
                valor = double.Parse(textoSolicitado);
                e.Handled = false;
            }
            catch (Exception)
            {
                e.Handled = true;
            }
        }

        private void lb_padrinos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Padrino pSel = lb_padrinos.SelectedItem as Padrino;

            if (pSel != null)
            {
                txt_nombre_pa.Text = pSel.Nombre;
                txt_apellidos_pa.Text = pSel.Apellidos;
                txt_telefono_pa.Text = pSel.Telefono;
                txt_aportacion_pa.Text = pSel.AportacionMensual.ToString();
                cb_formaPago_pa.SelectedIndex = pSel.FormaPago;
                txt_nCuenta_pa.Text = pSel.NumeroCuenta;
                dp_inicioApad_pa.SelectedDate = pSel.FechaComienzoApadrinamiento;
            }
            else
            {
                lb_padrinos.SelectedIndex = 0;
            }
        }

        private void mi_addPadrinos_Click(object sender, RoutedEventArgs e)
        {
            accion = "Añadir";
            //mostrar botones aceptar cancelar
            lbl_accionRealizar_pa.Content = accion;
            g_accion_pa.Visibility = Visibility.Visible;

            glb_padrinos.Visibility = Visibility.Collapsed;
            gs_padrinos.Visibility = Visibility.Collapsed;
            //vaciar campos
            lb_padrinos.SelectedItem = null;

            vaciarCamposPadrino();
            activarCamposPa(true);

            //bloquear navegacion
            ti_perros.IsEnabled = false;
            ti_socios.IsEnabled = false;
            ti_voluntarios.IsEnabled = false;
            ti_listas.IsEnabled = false;

            sp_botones_pa.IsEnabled = false;
        }

        private void activarCamposPa(bool v)
        {
            txt_nombre_pa.IsEnabled = v;
            txt_apellidos_pa.IsEnabled = v;
            txt_telefono_pa.IsEnabled = v;
            txt_aportacion_pa.IsEnabled = v;
            cb_formaPago_pa.IsEnabled = v;
            txt_nCuenta_pa.IsEnabled = v;
            dp_inicioApad_pa.IsEnabled = v;
        }

        private void vaciarCamposPadrino()
        {
            txt_nombre_pa.Text = "";
            txt_apellidos_pa.Text = "";
            txt_telefono_pa.Text = "";
            txt_aportacion_pa.Text = "";
            cb_formaPago_pa.SelectedIndex = 5;
            txt_nCuenta_pa.Text = "";
            dp_inicioApad_pa.SelectedDate = null;
        }

        private void mi_udtPadrinos_Click(object sender, RoutedEventArgs e)
        {
            if (lb_padrinos.Items.Count != 0)
            {
                accion = "Actualizar";
                //mostrar botones aceptar cancelar
                lbl_accionRealizar_pa.Content = accion;
                g_accion_pa.Visibility = Visibility.Visible;

                glb_padrinos.Visibility = Visibility.Collapsed;
                gs_padrinos.Visibility = Visibility.Collapsed;
                //desbloquear campos
                activarCamposPa(true);

                //bloquear navegacion
                ti_perros.IsEnabled = false;
                ti_socios.IsEnabled = false;
                ti_voluntarios.IsEnabled = false;
                ti_listas.IsEnabled = false;

                sp_botones_pa.IsEnabled = false;

            }
            else
            {
                MessageBox.Show("No hay un padrino para actualizar.", "Lista vacia");
            }
        }

        private void mi_delPadrinos_Click(object sender, RoutedEventArgs e)
        {
            if (lb_padrinos.Items.Count != 0)
            {
                if (MainWindow.PConfig.Sonidos)
                {
                    //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/llanto_3seg.wav");
                    //miSonido3.Play();
                    SystemSounds.Hand.Play();
                }
                Padrino pAux = lb_padrinos.SelectedItem as Padrino;
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que quieres borrar a " + pAux.Nombre + " " + pAux.Apellidos + "?", "Confirmación", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        MainWindow.Padrinos.Remove(pAux);
                        lb_padrinos.ItemsSource = null;
                        lb_padrinos.ItemsSource = MainWindow.Padrinos;
                        MessageBox.Show("Eliminación exitosa.", "Padrino borrado");
                        cb_padrinos_wc.ItemsSource = null;
                        cb_padrinos_wc.ItemsSource = MainWindow.Padrinos;
                        break;
                }
                if (MainWindow.Padrinos.Count == 0)
                {
                    vaciarCamposPadrino();
                }
            }
            else
            {
                MessageBox.Show("No hay un padrino para borrar.", "Lista vacia");
            }
        }

        private void btn_cancelar_pa_Click(object sender, RoutedEventArgs e)
        {
            //bloquear celdas
            activarCamposPa(false);
            //quitar colores
            quitarColoresPa();
            //activar listbox
            glb_padrinos.Visibility = Visibility.Visible;
            gs_padrinos.Visibility = Visibility.Visible;
            //ocultar accion
            g_accion_pa.Visibility = Visibility.Collapsed;

            lb_padrinos.ItemsSource = null;
            lb_padrinos.ItemsSource = MainWindow.Padrinos;
            //activar navegacion
            ti_perros.IsEnabled = true;
            ti_socios.IsEnabled = true;
            ti_voluntarios.IsEnabled = true;
            ti_listas.IsEnabled = true;

            sp_botones_pa.IsEnabled = true;
        }

        private void btn_aceptar_pa_Click(object sender, RoutedEventArgs e)
        {
            if (accion.Equals("Actualizar"))
            {
                //comprobarActualizar
                if (comprobarCeldasPa())
                {
                    //sonido
                    if (MainWindow.PConfig.Sonidos)
                    {
                        //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                        //miSonido3.Play();
                        SystemSounds.Hand.Play();
                    }
                    Padrino pAux = lb_padrinos.SelectedItem as Padrino;
                    pAux.actualizar(txt_nombre_pa.Text, txt_apellidos_pa.Text, txt_telefono_pa.Text, Convert.ToDouble(txt_aportacion_pa.Text), cb_formaPago_pa.SelectedIndex, txt_nCuenta_pa.Text, Convert.ToDateTime(dp_inicioApad_pa.SelectedDate));
                    //bloquear celdas
                    activarCamposPa(false);
                    //quitar colores
                    quitarColoresPa();
                    //activar listbox
                    glb_padrinos.Visibility = Visibility.Visible;
                    gs_padrinos.Visibility = Visibility.Visible;
                    //ocultar accion
                    g_accion_pa.Visibility = Visibility.Collapsed;


                    lb_padrinos.ItemsSource = null;
                    lb_padrinos.ItemsSource = MainWindow.Padrinos;

                    dg_padrinos.ItemsSource = null;
                    dg_padrinos.ItemsSource = MainWindow.Padrinos;
                    //mensaje
                    MessageBox.Show("Actualización exitosa.", "Padrino actualizado");
                    //activar navegacion
                    ti_perros.IsEnabled = true;
                    ti_socios.IsEnabled = true;
                    ti_voluntarios.IsEnabled = true;
                    ti_listas.IsEnabled = true;

                    sp_botones_pa.IsEnabled = true;
                    cb_padrinos_wc.ItemsSource = null;
                    cb_padrinos_wc.ItemsSource = MainWindow.Padrinos;
                }
                else
                {
                    MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
                }
            }
            else
            {
                //comprobarAñadir
                if (comprobarCeldasPa())
                {
                    //sonido
                    if (MainWindow.PConfig.Sonidos)
                    {
                        //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                        //miSonido3.Play();
                        SystemSounds.Hand.Play();
                    }
                    Padrino pAux = new Padrino(txt_nombre_pa.Text, txt_apellidos_pa.Text, txt_telefono_pa.Text, Convert.ToDouble(txt_aportacion_pa.Text), cb_formaPago_pa.SelectedIndex, txt_nCuenta_pa.Text, Convert.ToDateTime(dp_inicioApad_pa.SelectedDate));
                    MainWindow.Padrinos.Add(pAux);
                    //bloquear celdas
                    activarCamposPa(false);
                    //quitar colores
                    quitarColoresPa();
                    //activar listbox
                    glb_padrinos.Visibility = Visibility.Visible;
                    gs_padrinos.Visibility = Visibility.Visible;
                    //ocultar accion
                    g_accion_pa.Visibility = Visibility.Collapsed;

                    lb_padrinos.ItemsSource = null;
                    lb_padrinos.ItemsSource = MainWindow.Padrinos;

                    dg_padrinos.ItemsSource = null;
                    dg_padrinos.ItemsSource = MainWindow.Padrinos;
                    //mensaje
                    MessageBox.Show("Incorporación exitosa.", "Padrino añadido");
                    //activar navegacion
                    ti_perros.IsEnabled = true;
                    ti_socios.IsEnabled = true;
                    ti_voluntarios.IsEnabled = true;
                    ti_listas.IsEnabled = true;

                    sp_botones_pa.IsEnabled = true;
                    cb_padrinos_wc.ItemsSource = null;
                    cb_padrinos_wc.ItemsSource = MainWindow.Padrinos;

                }
                else
                {
                    MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
                }
            }
        }

        private bool comprobarCeldasPa()
        {
            bool valido = true;
            if (!MainWindow.comprobarNoVacio(txt_nombre_pa.Text, adv_nombre_pa))
            {
                valido = false;
            }
            if (!MainWindow.comprobarNoVacio(txt_apellidos_pa.Text, adv_apellidos_pa))
            {
                valido = false;
            }
            if (!comprobarTelefono(txt_telefono_pa.Text, adv_telefono_pa))
            {
                valido = false;
            }
            if (!MainWindow.comprobarNoVacio(txt_aportacion_pa.Text, adv_aportacion_pa))
            {
                valido = false;
            }
            if (!comprobarCuenta(txt_nCuenta_pa.Text, adv_cuenta_pa))
            {
                valido = false;
            }
            if (dp_inicioApad_pa.SelectedDate == null)
            {
                adv_fecha_pa.Visibility = Visibility.Visible;
                valido = false;
            }
            else
            {
                adv_fecha_pa.Visibility = Visibility.Collapsed;
            }
            if (cb_formaPago_pa.SelectedIndex == 5)
            {
                adv_fpago_pa.Visibility = Visibility.Visible;
                valido = false;
            }
            else
            {
                adv_fpago_pa.Visibility = Visibility.Collapsed;
            }
            return valido;
        }

        private void quitarColoresPa()
        {
            colorBase(adv_nombre_pa);
            colorBase(adv_apellidos_pa);
            colorBase(adv_telefono_pa);
            colorBase(adv_aportacion_pa);
            colorBase(adv_cuenta_pa);
            colorBase(adv_fecha_pa);
            colorBase(adv_fpago_pa);
        }

        private void lb_socios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Socio sSel = lb_socios.SelectedItem as Socio;

            if (sSel != null)
            {
                txt_nombre_so.Text = sSel.Nombre;
                txt_apellidos_so.Text = sSel.Apellidos;
                txt_correo_so.Text = sSel.Correo;
                txt_ayuda_so.Text = sSel.CuantiaAyuda.ToString();
                cb_formaPago_so.SelectedIndex = sSel.FormaPago;
                txt_titularCuenta_so.Text = sSel.TitularCuenta;
                txt_nCuenta_so.Text = sSel.NumeroCuenta;
            }
            else
            {
                lb_socios.SelectedIndex = 0;
            }
        }

        private void mi_addSocios_Click(object sender, RoutedEventArgs e)
        {
            accion = "Añadir";
            //mostrar botones aceptar cancelar
            lbl_accionRealizar_so.Content = accion;
            g_accion_so.Visibility = Visibility.Visible;

            glb_socios.Visibility = Visibility.Collapsed;
            gs_socios.Visibility = Visibility.Collapsed;
            //vaciar campos
            lb_socios.SelectedItem = null;

            vaciarCamposSocio();
            activarCamposSo(true);

            //bloquear navegacion
            ti_perros.IsEnabled = false;
            ti_padrinos.IsEnabled = false;
            ti_voluntarios.IsEnabled = false;
            ti_listas.IsEnabled = false;

            sp_botones_so.IsEnabled = false;
        }

        private void vaciarCamposSocio()
        {
            txt_nombre_so.Text = "";
            txt_apellidos_so.Text = "";
            txt_correo_so.Text = "";
            txt_ayuda_so.Text = "";
            cb_formaPago_so.SelectedIndex = 5;
            txt_titularCuenta_so.Text = "";
            txt_nCuenta_so.Text = "";
        }

        private void mi_udtSocios_Click(object sender, RoutedEventArgs e)
        {
            if (lb_socios.Items.Count != 0)
            {
                accion = "Actualizar";
                //mostrar botones aceptar cancelar
                lbl_accionRealizar_so.Content = accion;
                g_accion_so.Visibility = Visibility.Visible;

                glb_socios.Visibility = Visibility.Collapsed;
                gs_socios.Visibility = Visibility.Collapsed;
                //desbloquear campos
                activarCamposSo(true);

                //bloquear navegacion
                ti_perros.IsEnabled = false;
                ti_padrinos.IsEnabled = false;
                ti_voluntarios.IsEnabled = false;
                ti_listas.IsEnabled = false;

                sp_botones_so.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("No hay un socio para actualizar.", "Lista vacia");
            }
        }

        private void activarCamposSo(bool v)
        {
            txt_nombre_so.IsEnabled = v;
            txt_apellidos_so.IsEnabled = v;
            txt_correo_so.IsEnabled = v;
            txt_ayuda_so.IsEnabled = v;
            cb_formaPago_so.IsEnabled = v;
            txt_titularCuenta_so.IsEnabled = v;
            txt_nCuenta_so.IsEnabled = v;
        }

        private void mi_delSocios_Click(object sender, RoutedEventArgs e)
        {
            if (lb_socios.Items.Count != 0)
            {
                if (MainWindow.PConfig.Sonidos)
                {
                    //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/llanto_3seg.wav");
                    //miSonido3.Play();
                    SystemSounds.Hand.Play();
                }
                Socio sAux = lb_socios.SelectedItem as Socio;
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que quieres borrar a " + sAux.Nombre + " " + sAux.Apellidos + "?", "Confirmación", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        MainWindow.Socios.Remove(sAux);
                        lb_socios.ItemsSource = null;
                        lb_socios.ItemsSource = MainWindow.Socios;
                        MessageBox.Show("Eliminación exitosa.", "Socio borrado");
                        break;
                }
                if (MainWindow.Socios.Count == 0)
                {
                    vaciarCamposSocio();
                }
            }
            else
            {
                MessageBox.Show("No hay un socio para borrar.", "Lista vacia");
            }
        }

        private void btn_cancelar_so_Click(object sender, RoutedEventArgs e)
        {
            //bloquear celdas
            activarCamposSo(false);
            //quitar colores
            quitarColoresSo();
            //activar listbox
            glb_socios.Visibility = Visibility.Visible;
            gs_socios.Visibility = Visibility.Visible;
            //ocultar accion
            g_accion_so.Visibility = Visibility.Collapsed;

            lb_socios.ItemsSource = null;
            lb_socios.ItemsSource = MainWindow.Socios;
            //activar navegacion
            ti_perros.IsEnabled = true;
            ti_padrinos.IsEnabled = true;
            ti_voluntarios.IsEnabled = true;
            ti_listas.IsEnabled = true;

            sp_botones_so.IsEnabled = true;
        }

        private void btn_aceptar_so_Click(object sender, RoutedEventArgs e)
        {
            if (accion.Equals("Actualizar"))
            {
                //comprobarActualizar
                if (comprobarCeldasSo())
                {
                    //sonido
                    if (MainWindow.PConfig.Sonidos)
                    {
                        //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                        //miSonido3.Play();
                        SystemSounds.Hand.Play();
                    }

                    Socio sAux = lb_socios.SelectedItem as Socio;
                    sAux.Actualizar(txt_nombre_so.Text, txt_apellidos_so.Text, txt_correo_so.Text, txt_titularCuenta_so.Text, txt_nCuenta_so.Text, Convert.ToDouble(txt_ayuda_so.Text), cb_formaPago_so.SelectedIndex);
                    //bloquear celdas
                    activarCamposSo(false);
                    //quitar colores
                    quitarColoresSo();
                    //activar listbox
                    glb_socios.Visibility = Visibility.Visible;
                    gs_socios.Visibility = Visibility.Visible;
                    //ocultar accion
                    g_accion_so.Visibility = Visibility.Collapsed;


                    lb_socios.ItemsSource = null;
                    lb_socios.ItemsSource = MainWindow.Socios;

                    dg_socios.ItemsSource = null;
                    dg_socios.ItemsSource = MainWindow.Socios;

                    //mensaje
                    MessageBox.Show("Actualización exitosa.", "Socio actualizado");
                    //activar navegacion
                    ti_perros.IsEnabled = true;
                    ti_padrinos.IsEnabled = true;
                    ti_voluntarios.IsEnabled = true;
                    ti_listas.IsEnabled = true;

                    sp_botones_so.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
                }
            }
            else
            {
                //comprobarAñadir
                if (comprobarCeldasSo())
                {
                    //sonido
                    if (MainWindow.PConfig.Sonidos)
                    {
                        //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                        //miSonido3.Play();
                        SystemSounds.Hand.Play();
                    }

                    Socio sAux = new Socio(txt_nombre_so.Text, txt_apellidos_so.Text, txt_correo_so.Text, txt_titularCuenta_so.Text, txt_nCuenta_so.Text, Convert.ToDouble(txt_ayuda_so.Text), cb_formaPago_so.SelectedIndex);
                    MainWindow.Socios.Add(sAux);
                    //bloquear celdas
                    activarCamposSo(false);
                    //quitar colores
                    quitarColoresSo();
                    //activar listbox
                    glb_socios.Visibility = Visibility.Visible;
                    gs_socios.Visibility = Visibility.Visible;
                    //ocultar accion
                    g_accion_so.Visibility = Visibility.Collapsed;

                    lb_socios.ItemsSource = null;
                    lb_socios.ItemsSource = MainWindow.Socios;

                    dg_socios.ItemsSource = null;
                    dg_socios.ItemsSource = MainWindow.Socios;
                    //mensaje
                    MessageBox.Show("Incorporación exitosa.", "Socio añadido");
                    //activar navegacion
                    ti_perros.IsEnabled = true;
                    ti_padrinos.IsEnabled = true;
                    ti_voluntarios.IsEnabled = true;
                    ti_listas.IsEnabled = true;

                    sp_botones_so.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
                }
            }
        }

        private bool comprobarCeldasSo()
        {
            bool valido = true;
            if (!MainWindow.comprobarNoVacio(txt_nombre_so.Text, adv_nombre_so))
            {
                valido = false;
            }
            if (!MainWindow.comprobarNoVacio(txt_apellidos_so.Text, adv_apellidos_so))
            {
                valido = false;
            }
            if (!MainWindow.comprobarNoVacio(txt_correo_so.Text, adv_correo_so))
            {
                valido = false;
            }
            if (!MainWindow.comprobarNoVacio(txt_ayuda_so.Text, adv_ayuda_so))
            {
                valido = false;
            }
            if (!comprobarCuenta(txt_nCuenta_so.Text, adv_cuenta_so))
            {
                valido = false;
            }
            if (!MainWindow.comprobarNoVacio(txt_titularCuenta_so.Text, adv_tCuenta_so))
            {
                valido = false;
            }
            if (cb_formaPago_so.SelectedIndex == 5)
            {
                adv_fpago_so.Visibility = Visibility.Visible;
                valido = false;
            }
            else
            {
                adv_fpago_so.Visibility = Visibility.Collapsed;
            }
            return valido;
        }

        private void quitarColoresSo()
        {
            colorBase(adv_nombre_so);
            colorBase(adv_apellidos_so);
            colorBase(adv_correo_so);
            colorBase(adv_ayuda_so);
            colorBase(adv_tCuenta_so);
            colorBase(adv_cuenta_so);
            colorBase(adv_fpago_so);
        }

        private void lb_voluntarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Voluntario vSel = lb_voluntarios.SelectedItem as Voluntario;
            if (vSel != null)
            {
                //cargarImagen
                var bitmap = new BitmapImage(vSel.Foto);
                img_foto_vo.Source = bitmap;

                txt_nombre_vo.Text = vSel.Nombre;
                txt_apellidos_vo.Text = vSel.Apellidos;
                txt_dni_vo.Text = vSel.Dni;
                txt_correo_vo.Text = vSel.Correo;
                txt_telefono_vo.Text = vSel.Telefono;
                txt_horario_vo.Text = vSel.HorarioDisponibilidad;
                txt_zona_vo.Text = vSel.ZonaActuacion;

                if (tbtn_conocimientos_vo.Toggled != vSel.ConocimientosVeterinarios)
                {
                    tbtn_conocimientos_vo.cambiar();
                }
                if (vSel.ConocimientosVeterinarios)
                {
                    lbl_conocimientos.Content = "Posee";
                }
                else
                {
                    lbl_conocimientos.Content = "No posee";
                }
            }
            else
            {
                lb_voluntarios.SelectedIndex = 0;
            }
        }

        private void mi_addVoluntarios_Click(object sender, RoutedEventArgs e)
        {
            accion = "Añadir";
            //mostrar botones aceptar cancelar
            lbl_accionRealizar_vo.Content = accion;
            g_accion_vo.Visibility = Visibility.Visible;

            glb_voluntarios.Visibility = Visibility.Collapsed;
            gs_voluntarios.Visibility = Visibility.Collapsed;
            //vaciar campos
            lb_voluntarios.SelectedItem = null;

            vaciarCamposVoluntario();
            activarCamposVo(true);

            //bloquear navegacion
            ti_perros.IsEnabled = false;
            ti_socios.IsEnabled = false;
            ti_padrinos.IsEnabled = false;
            ti_listas.IsEnabled = false;

            sp_botones_vo.IsEnabled = false;
        }

        private void activarCamposVo(bool v)
        {
            btn_cargarImg_vo.IsEnabled = v;
            txt_nombre_vo.IsEnabled = v;
            txt_apellidos_vo.IsEnabled = v;
            txt_dni_vo.IsEnabled = v;
            txt_correo_vo.IsEnabled = v;
            txt_telefono_vo.IsEnabled = v;
            txt_horario_vo.IsEnabled = v;
            txt_zona_vo.IsEnabled = v;
            tbtn_conocimientos_vo.IsEnabled = v;
        }

        private void mi_udtVoluntarios_Click(object sender, RoutedEventArgs e)
        {
            if (lb_voluntarios.Items.Count != 0)
            {
                accion = "Actualizar";
                //mostrar botones aceptar cancelar
                lbl_accionRealizar_vo.Content = accion;
                g_accion_vo.Visibility = Visibility.Visible;

                glb_voluntarios.Visibility = Visibility.Collapsed;
                gs_voluntarios.Visibility = Visibility.Collapsed;
                //desbloquear campos
                activarCamposVo(true);

                //bloquear navegacion
                ti_perros.IsEnabled = false;
                ti_socios.IsEnabled = false;
                ti_padrinos.IsEnabled = false;
                ti_listas.IsEnabled = false;

                sp_botones_vo.IsEnabled = false;

            }
            else
            {
                MessageBox.Show("No hay un voluntario para actualizar.", "Lista vacia");
            }
        }

        private void mi_delVoluntarios_Click(object sender, RoutedEventArgs e)
        {
            if (lb_voluntarios.Items.Count != 0)
            {
                if (MainWindow.PConfig.Sonidos)
                {
                    //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/llanto_3seg.wav");
                    //miSonido3.Play();
                    SystemSounds.Hand.Play();
                }
                Voluntario vAux = lb_voluntarios.SelectedItem as Voluntario;
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que quieres borrar a " + vAux.Nombre + " " + vAux.Apellidos + "?", "Confirmación", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        MainWindow.Voluntarios.Remove(vAux);
                        lb_voluntarios.ItemsSource = null;
                        lb_voluntarios.ItemsSource = MainWindow.Voluntarios;
                        MessageBox.Show("Eliminación exitosa.", "Voluntario borrado");
                        break;
                }
                if (MainWindow.Voluntarios.Count == 0)
                {
                    vaciarCamposVoluntario();
                }
            }
            else
            {
                MessageBox.Show("No hay un voluntario para borrar.", "Lista vacia");
            }
        }

        private void vaciarCamposVoluntario()
        {
            //cargarImagen
            var bitmap = new BitmapImage(imgDefecto);
            img_foto_vo.Source = bitmap;

            txt_nombre_vo.Text = "";
            txt_apellidos_vo.Text = "";
            txt_dni_vo.Text = "";
            txt_correo_vo.Text = "";
            txt_telefono_vo.Text = "";
            txt_horario_vo.Text = "";
            txt_zona_vo.Text = "";

            if (tbtn_conocimientos_vo.Toggled)
            {
                tbtn_conocimientos_vo.cambiar();
            }
        }

        private void btn_cancelar_vo_Click(object sender, RoutedEventArgs e)
        {
            //bloquear celdas
            activarCamposVo(false);
            //quitar colores
            quitarColoresVo();
            //activar listbox
            glb_voluntarios.Visibility = Visibility.Visible;
            gs_voluntarios.Visibility = Visibility.Visible;
            //ocultar accion
            g_accion_vo.Visibility = Visibility.Collapsed;

            lb_voluntarios.ItemsSource = null;
            lb_voluntarios.ItemsSource = MainWindow.Voluntarios;
            //activar navegacion
            ti_perros.IsEnabled = true;
            ti_socios.IsEnabled = true;
            ti_padrinos.IsEnabled = true;
            ti_listas.IsEnabled = true;

            sp_botones_vo.IsEnabled = true;
        }

        private void quitarColoresVo()
        {
            colorBase(adv_nombre_vo);
            colorBase(adv_apellidos_vo);
            colorBase(adv_dni_vo);
            colorBase(adv_correo_vo);
            colorBase(adv_telefono_vo);
            colorBase(adv_horario_vo);
            colorBase(adv_zona_vo);
        }

        private void btn_aceptar_vo_Click(object sender, RoutedEventArgs e)
        {
            if (accion.Equals("Actualizar"))
            {
                //comprobarActualizar
                if (comprobarCeldasVo())
                {
                    //sonido
                    if (MainWindow.PConfig.Sonidos)
                    {
                        //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                        //miSonido3.Play();
                        SystemSounds.Hand.Play();
                    }
                    Voluntario vAux = lb_voluntarios.SelectedItem as Voluntario;
                    vAux.actualizar(txt_nombre_vo.Text, txt_apellidos_vo.Text, txt_correo_vo.Text, txt_dni_vo.Text, txt_telefono_vo.Text, (img_foto_vo.Source as BitmapImage).UriSource, txt_horario_vo.Text, txt_zona_vo.Text, tbtn_conocimientos_vo.Toggled);
                    //bloquear celdas
                    activarCamposVo(false);
                    //quitar colores
                    quitarColoresVo();
                    //activar listbox
                    glb_voluntarios.Visibility = Visibility.Visible;
                    gs_voluntarios.Visibility = Visibility.Visible;
                    //ocultar accion
                    g_accion_vo.Visibility = Visibility.Collapsed;

                    lb_voluntarios.ItemsSource = null;
                    lb_voluntarios.ItemsSource = MainWindow.Voluntarios;

                    dg_voluntarios.ItemsSource = null;
                    dg_voluntarios.ItemsSource = MainWindow.Voluntarios;
                    //mensaje
                    MessageBox.Show("Actualización exitosa.", "Voluntario actualizado");
                    //activar navegacion
                    ti_perros.IsEnabled = true;
                    ti_padrinos.IsEnabled = true;
                    ti_socios.IsEnabled = true;
                    ti_listas.IsEnabled = true;

                    sp_botones_vo.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
                }
            }
            else
            {
                //comprobarAñadir
                if (comprobarCeldasVo())
                {
                    //sonido
                    if (MainWindow.PConfig.Sonidos)
                    {
                        //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                        //miSonido3.Play();
                        SystemSounds.Hand.Play();
                    }
                    Voluntario vAux = new Voluntario(txt_nombre_vo.Text, txt_apellidos_vo.Text, txt_correo_vo.Text, txt_dni_vo.Text, txt_telefono_vo.Text, (img_foto_vo.Source as BitmapImage).UriSource, txt_horario_vo.Text, txt_zona_vo.Text, tbtn_conocimientos_vo.Toggled);
                    MainWindow.Voluntarios.Add(vAux);
                    //bloquear celdas
                    activarCamposVo(false);
                    //quitar colores
                    quitarColoresVo();
                    //activar listbox
                    glb_voluntarios.Visibility = Visibility.Visible;
                    gs_voluntarios.Visibility = Visibility.Visible;
                    //ocultar accion
                    g_accion_vo.Visibility = Visibility.Collapsed;

                    lb_voluntarios.ItemsSource = null;
                    lb_voluntarios.ItemsSource = MainWindow.Voluntarios;

                    dg_voluntarios.ItemsSource = null;
                    dg_voluntarios.ItemsSource = MainWindow.Voluntarios;
                    //mensaje
                    MessageBox.Show("Incorporación exitosa.", "Voluntario añadido");
                    //activar navegacion
                    ti_perros.IsEnabled = true;
                    ti_padrinos.IsEnabled = true;
                    ti_socios.IsEnabled = true;
                    ti_listas.IsEnabled = true;

                    sp_botones_vo.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
                }
            }
        }

        private bool comprobarCeldasVo()
        {
            bool valido = true;
            if (!MainWindow.comprobarNoVacio(txt_nombre_vo.Text, adv_nombre_vo))
            {
                valido = false;
            }
            if (!MainWindow.comprobarNoVacio(txt_apellidos_vo.Text, adv_apellidos_vo))
            {
                valido = false;
            }
            if (!MainWindow.comprobarNoVacio(txt_dni_vo.Text, adv_dni_vo))
            {
                valido = false;
            }
            if (!MainWindow.comprobarNoVacio(txt_correo_vo.Text, adv_correo_vo))
            {
                valido = false;
            }
            if (!comprobarTelefono(txt_telefono_vo.Text, adv_telefono_vo))
            {
                valido = false;
            }
            if (!MainWindow.comprobarNoVacio(txt_horario_vo.Text, adv_horario_vo))
            {
                valido = false;
            }
            if (!MainWindow.comprobarNoVacio(txt_zona_vo.Text, adv_zona_vo))
            {
                valido = false;
            }
            return valido;
        }

        private void btn_cargarImg_vo_Click(object sender, RoutedEventArgs e)
        {
            cargarImg(img_foto_vo);
        }

        private void cargarImg(Image im)
        {
            var abrirDialog = new OpenFileDialog();
            abrirDialog.Filter = "Images|*.jpg;*.gif;*.bmp;*.png";
            if (abrirDialog.ShowDialog() == true)
            {
                try
                {
                    var bitmap = new BitmapImage(new Uri(abrirDialog.FileName, UriKind.Absolute));
                    im.Source = bitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen " + ex.Message);
                }
            }
        }

        private void tbtn_conocimientos_vo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (tbtn_conocimientos_vo.Toggled)
            {
                lbl_conocimientos.Content = "Posee";
            }
            else
            {
                lbl_conocimientos.Content = "No posee";
            }
        }

        private void tbtn_sociable_wc_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (tbtn_sociable_wc.Toggled)
            {
                lbl_sociable_p.Content = "Es sociable";
            }
            else
            {
                lbl_sociable_p.Content = "No es sociable";
            }
        }

        private void tbtn_ppp_wc_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (tbtn_ppp_wc.Toggled)
            {
                lbl_ppp_p.Content = "Es ppp";
            }
            else
            {
                lbl_ppp_p.Content = "No es ppp";
            }
        }

        private void tbtn_vacunado_wc_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (tbtn_vacunado_wc.Toggled)
            {
                lbl_vacunado_p.Content = "Está vacunado";
            }
            else
            {
                lbl_vacunado_p.Content = "No está vacunado";
            }
        }

        private void tbtn_esterilizado_wc_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (tbtn_esterilizado_wc.Toggled)
            {
                lbl_esterilizado_p.Content = "Está esterilizado";
            }
            else
            {
                lbl_esterilizado_p.Content = "No está esterilizado";
            }
        }

        private void cb_lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cb_lista.SelectedIndex)
            {
                case 0:
                    //listas
                    dg_perros.Visibility = Visibility.Visible;
                    dg_padrinos.Visibility = Visibility.Collapsed;
                    dg_socios.Visibility = Visibility.Collapsed;
                    dg_voluntarios.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    dg_perros.Visibility = Visibility.Collapsed;
                    dg_padrinos.Visibility = Visibility.Visible;
                    dg_socios.Visibility = Visibility.Collapsed;
                    dg_voluntarios.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    dg_perros.Visibility = Visibility.Collapsed;
                    dg_padrinos.Visibility = Visibility.Collapsed;
                    dg_socios.Visibility = Visibility.Visible;
                    dg_voluntarios.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    dg_perros.Visibility = Visibility.Collapsed;
                    dg_padrinos.Visibility = Visibility.Collapsed;
                    dg_socios.Visibility = Visibility.Collapsed;
                    dg_voluntarios.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void btn_ver_Click(object sender, RoutedEventArgs e)
        {
            switch (cb_lista.SelectedIndex)
            {
                case 0:
                    lb_perros.SelectedIndex = dg_perros.SelectedIndex;
                    tc_gestion.SelectedIndex = 0;
                    break;
                case 1:
                    lb_padrinos.SelectedIndex = dg_padrinos.SelectedIndex;
                    tc_gestion.SelectedIndex = 1;
                    break;
                case 2:
                    lb_socios.SelectedIndex = dg_socios.SelectedIndex;
                    tc_gestion.SelectedIndex = 2;
                    break;
                case 3:
                    lb_voluntarios.SelectedIndex = dg_voluntarios.SelectedIndex;
                    tc_gestion.SelectedIndex = 3;
                    break;

            }
        }



        private void txt_telefono_pa_TextChanged(object sender, TextChangedEventArgs e)
        {
            (sender as TextBox).Text = telefonoValido(quitarSeparadores((sender as TextBox).Text));
            (sender as TextBox).CaretIndex = (sender as TextBox).Text.Length;
        }

        private string telefonoValido(string texto)
        {
            //MessageBox.Show(texto);
            string textoValido = "";
            //dejar solo numeros
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    textoValido += c;
                }
            }
            //controlar longitud
            if (textoValido.Length > 9)
            {
                textoValido = textoValido.Substring(0, 9);
            }
            return aniadirSeparaciones(textoValido);
        }

        private string aniadirSeparaciones(string text)
        {
            if (text.Length >= 4)
            {
                //poner un separador
                text = text.Insert(3, "-");
            }
            if (text.Length >= 8)
            {
                //poner un separador
                text = text.Insert(7, "-");
            }
            return text;
        }

        private void txt_nCuenta_pa_TextChanged(object sender, TextChangedEventArgs e)
        {
            (sender as TextBox).Text = cuentaValida(quitarSeparadores((sender as TextBox).Text));
            (sender as TextBox).CaretIndex = (sender as TextBox).Text.Length;
        }

        private string quitarSeparadores(string text)
        {
            string textoValido = "";

            foreach (char c in text)
            {
                if (c != '-')
                {
                    textoValido += c;
                }
            }
            return textoValido;
        }

        private string cuentaValida(string text)
        {
            string textoValido = "";

            //asignar 2 letras
            //asignar hasta 22 numeros
            for (int i = 0; i < text.Length; i++)
            {
                if (i < 2)
                {
                    if (char.IsLetter(text.ElementAt(i)))
                    {
                        textoValido += text.ElementAt(i);
                    }
                }
                else
                {
                    if (char.IsDigit(text.ElementAt(i)))
                    {
                        textoValido += text.ElementAt(i);
                    }
                }
            }

            //controlar longitud
            if (textoValido.Length > 24)
            {
                textoValido = textoValido.Substring(0, 24);
            }

            return aniadirSeparacionesCuenta(textoValido);
        }

        private string aniadirSeparacionesCuenta(string text)
        {
            if (text.Length >= 5)
            {
                //poner un separador
                text = text.Insert(4, "-");
            }
            if (text.Length >= 10)
            {
                //poner un separador
                text = text.Insert(9, "-");
            }
            if (text.Length >= 15)
            {
                //poner un separador
                text = text.Insert(14, "-");
            }
            if (text.Length >= 20)
            {
                //poner un separador
                text = text.Insert(19, "-");
            }
            if (text.Length >= 25)
            {
                //poner un separador
                text = text.Insert(24, "-");
            }
            return text;
        }


        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            if (MainWindow.PConfig.Sonidos)
            {
                //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/ladridosCachorro.wav");
                //miSonido3.Play();
                //SystemSounds.Hand.Play();
            }
        }


        public static void asignarUSuario(Administrador a)
        {
            nombreUsuario.Content = a.Nombre;
            apellidosUsuario.Content = a.Apellidos;
            ultimoInicio.Content = a.UltimoAcceso.ToString();
        }

        private void txt_nombre_wc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_nombre_wc.Text, adv_nombre_p);
                cbx_sexo_p.Focus();
            }
        }

        private void txt_edad_wc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_edad_wc.Text, adv_edad_p);
                txt_peso_wc.Focus();
            }
        }

        private void txt_peso_wc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_peso_wc.Text, adv_peso_p);
                txt_raza_wc.Focus();
            }
        }

        private void txt_descripcion_wc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                cb_padrinos_wc.Focus();
            }
        }

        private void txt_chip_wc_KeyDown(object sender, KeyEventArgs e)
        {
            dp_fechaEntrada_wc.Focus();
        }

        private void txt_nombre_pa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_nombre_pa.Text, adv_nombre_pa);
                txt_apellidos_pa.Focus();
            }
        }

        private void txt_apellidos_pa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_apellidos_pa.Text, adv_apellidos_pa);
                txt_telefono_pa.Focus();
            }
        }

        private void txt_aportacion_pa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_aportacion_pa.Text, adv_aportacion_pa);
                cbx_formaPago_pa.Focus();
            }
        }

        private void txt_nCuenta_pa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                comprobarCuenta(txt_aportacion_pa.Text, adv_aportacion_pa);
                dp_inicioApad_pa.Focus();
            }
        }

        private bool comprobarCuenta(string text, Image i)
        {
            if (text.Length != 29)
            {
                i.Visibility = Visibility.Visible;
                return false;
            }
            else
            {
                i.Visibility = Visibility.Collapsed;
                return true;
            }
        }

        private void txt_telefono_pa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                comprobarTelefono(txt_telefono_pa.Text, adv_telefono_pa);
            }
        }

        private bool comprobarTelefono(string text, Image i)
        {
            if (text.Length != 11)
            {
                i.Visibility = Visibility.Visible;
                return false;
            }
            else
            {
                i.Visibility = Visibility.Collapsed;
                return true;
            }
        }

        private void txt_nombre_so_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_nombre_so.Text, adv_nombre_so);
                txt_apellidos_so.Focus();
            }
        }

        private void txt_apellidos_so_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_apellidos_so.Text, adv_apellidos_so);
                txt_correo_so.Focus();
            }
        }

        private void txt_correo_so_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_correo_so.Text, adv_correo_so);
            }
        }

        private void txt_ayuda_so_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_ayuda_so.Text, adv_ayuda_so);
                cb_formaPago_so.Focus();
            }
        }

        private void txt_titularCuenta_so_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_titularCuenta_so.Text, adv_tCuenta_so);
                txt_nCuenta_so.Focus();
            }
        }

        private void txt_nCuenta_so_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                comprobarCuenta(txt_nCuenta_so.Text, adv_cuenta_so);
            }
        }

        private void txt_nombre_vo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_nombre_vo.Text, adv_nombre_vo);
                txt_apellidos_vo.Focus();
            }
        }

        private void txt_apellidos_vo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_apellidos_vo.Text, adv_apellidos_vo);
                txt_dni_vo.Focus();
            }
        }

        private void txt_dni_vo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_dni_vo.Text, adv_dni_vo);
            }
        }

        private void txt_correo_vo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_correo_vo.Text, adv_correo_vo);
                txt_telefono_vo.Focus();
            }
        }

        private void txt_telefono_vo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                comprobarTelefono(txt_telefono_vo.Text, adv_telefono_vo);
            }
        }

        private void txt_horario_vo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_horario_vo.Text, adv_horario_vo);
                txt_zona_vo.Focus();
            }
        }

        private void txt_zona_vo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MainWindow.comprobarNoVacio(txt_zona_vo.Text, adv_zona_vo);
            }
        }


    }
}

