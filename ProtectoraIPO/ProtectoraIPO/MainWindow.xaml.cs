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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace ProtectoraIPO
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //listas
        public static List<Administrador> Administradores;
        public static List<Padrino> Padrinos;
        public static List<Perro> Perros;
        public static List<Socio> Socios;
        public static List<Voluntario> Voluntarios;
        public static List<Paso> Pasos;
        public static List<Ayuda> Ayudas;
        public static Preferencia PConfig;
        private string codigoAdmin;

        //componentes
        public static Button b_config_L;
        public static Button b_ayuda_L;
        public static Win_Control wMarco;
        public static win_Ayuda wAyuda;

        public static Image gif;
        public static Image nogif;

        //variables login
        public static Administrador aAux;

        public MainWindow()
        {
            InitializeComponent();
            cargarDatos();
            gif = gif_main;
            nogif = nogif_main;
            b_config_L = btn_config;
            b_ayuda_L = btn_ayuda;
            wMarco = new Win_Control(this);
            wAyuda = new win_Ayuda(Ayudas);
            wMarco.Visibility = Visibility.Collapsed;
            win_Preferencias.aplicarCambios();
        }

        public void cargarDatos()
        {
            Padrinos = cargarPadrinos();
            Perros = cargarPerros();
            Socios = cargarSocios();
            Voluntarios = cargarVoluntarios();
            Administradores = cargarAdmins();
            codigoAdmin = cargarCodigoAdmin();
            Pasos = cargarPasos();
            Ayudas = cargarAyudas();
            PConfig = cargarPreferencias();
        }

        private Preferencia cargarPreferencias()
        {
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(Directory.GetCurrentDirectory() + @"/Preferencias.xml");
            }
            catch (Exception)
            {
                var fichero = Application.GetResourceStream(new Uri("Ficheros/Preferencias.xml", UriKind.Relative));
                doc.Load(fichero.Stream);
            }

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevaPreferencia = new Preferencia(Convert.ToBoolean(node.Attributes["Scroll"].Value), Convert.ToInt32(node.Attributes["TBotones"].Value),
                    Convert.ToInt32(node.Attributes["TFuentes"].Value), Convert.ToInt32(node.Attributes["TIconos"].Value),
                    Convert.ToBoolean(node.Attributes["TemaClaro"].Value), Convert.ToBoolean(node.Attributes["Gif"].Value),
                    Convert.ToBoolean(node.Attributes["Sonidos"].Value));
                return nuevaPreferencia;
            }
            return null;
        }

        private List<Ayuda> cargarAyudas()
        {
            List<Ayuda> listado = new List<Ayuda>();
            // Cargar contenido de prueba
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Ficheros/Ayudas.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoAyuda = new Ayuda(Convert.ToInt32(node.Attributes["Id"].Value), node.Attributes["Titulo"].Value, generarPasos(node.Attributes["Pasos"].Value));
                listado.Add(nuevoAyuda);
            }
            return listado;
        }

        private Paso[] generarPasos(string v)
        {
            List<int> pasosIds = new List<int>();
            v = v.Substring(1, v.Length - 2);
            string[] ids = v.Split(',');
            List<Paso> pasosSel = new List<Paso>();

            foreach (string id in ids)
            {
                foreach (Paso pAux in Pasos)
                {
                    if (pAux.Id == int.Parse(id))
                    {
                        pasosSel.Add(pAux);
                        break;
                    }
                }
            }
            return pasosSel.ToArray();
        }

        private List<Paso> cargarPasos()
        {
            List<Paso> listado = new List<Paso>();
            // Cargar contenido de prueba
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Ficheros/Pasos.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoPaso = new Paso(Convert.ToInt32(node.Attributes["Id"].Value), node.Attributes["Descripcion"].Value, new Uri(node.Attributes["Foto"].Value, UriKind.Relative));
                listado.Add(nuevoPaso);
            }
            return listado;
        }

        private string cargarCodigoAdmin()
        {
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Ficheros/CodigoAdmin.xml", UriKind.Relative));
            doc.Load(fichero.Stream);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                return node.Attributes["CodigoAdmin"].Value;
            }
            return null;
        }

        private List<Administrador> cargarAdmins()
        {
            List<Administrador> listado = new List<Administrador>();
            // Cargar contenido de prueba
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(Directory.GetCurrentDirectory() + @"/Administradores.xml");
            }
            catch (Exception)
            {
                var fichero = Application.GetResourceStream(new Uri("Ficheros/Administradores.xml", UriKind.Relative));
                doc.Load(fichero.Stream);
            }

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoAdmin = new Administrador(node.Attributes["Usuario"].Value, node.Attributes["Contrasenia"].Value, node.Attributes["Nombre"].Value,
                    node.Attributes["Apellidos"].Value, generarFecha(node.Attributes["UltimoAcceso"].Value));
                listado.Add(nuevoAdmin);
            }
            return listado;
        }

        private DateTime generarFecha(string value)
        {
            if (value.Equals("-1"))
            {
                return DateTime.Now;
            }
            else
            {
                return Convert.ToDateTime(value);
            }
        }

        private List<Voluntario> cargarVoluntarios()
        {
            List<Voluntario> listado = new List<Voluntario>();
            // Cargar contenido de prueba
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(Directory.GetCurrentDirectory() + @"/Voluntarios.xml");
            }
            catch (Exception)
            {
                var fichero = Application.GetResourceStream(new Uri("Ficheros/Voluntarios.xml", UriKind.Relative));
                doc.Load(fichero.Stream);
            }

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoVoluntario = new Voluntario(node.Attributes["Nombre"].Value, node.Attributes["Apellidos"].Value, node.Attributes["Correo"].Value,
                    node.Attributes["DNI"].Value, node.Attributes["Telefono"].Value, new Uri(node.Attributes["Foto"].Value, UriKind.RelativeOrAbsolute),
                    node.Attributes["HorarioDisponibilidad"].Value, node.Attributes["ZonaActuacion"].Value, Convert.ToBoolean(node.Attributes["ConocimientosVeterinarios"].Value));
                listado.Add(nuevoVoluntario);
            }
            return listado;
        }

        private List<Padrino> cargarPadrinos()
        {
            List<Padrino> listado = new List<Padrino>();
            // Cargar contenido de prueba
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(Directory.GetCurrentDirectory() + @"/Padrinos.xml");
            }
            catch (Exception)
            {
                var fichero = Application.GetResourceStream(new Uri("Ficheros/Padrinos.xml", UriKind.Relative));
                doc.Load(fichero.Stream);
            }

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoPadrino = new Padrino(node.Attributes["Nombre"].Value, node.Attributes["Apellidos"].Value,
                    node.Attributes["Telefono"].Value, Convert.ToDouble(node.Attributes["AportacionMensual"].Value), Convert.ToInt32(node.Attributes["FormaPago"].Value),
                    node.Attributes["Cuenta"].Value, Convert.ToDateTime(node.Attributes["FechaComienzoApadrinamiento"].Value));
                listado.Add(nuevoPadrino);
            }
            return listado;
        }
        private List<Socio> cargarSocios()
        {
            List<Socio> listado = new List<Socio>();
            // Cargar contenido de prueba
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(Directory.GetCurrentDirectory() + @"/Socios.xml");
            }
            catch (Exception)
            {
                var fichero = Application.GetResourceStream(new Uri("Ficheros/Socios.xml", UriKind.Relative));
                doc.Load(fichero.Stream);
            }

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoSocio = new Socio(node.Attributes["Nombre"].Value, node.Attributes["Apellidos"].Value, node.Attributes["Correo"].Value,
                    node.Attributes["TitularCuenta"].Value, node.Attributes["NumeroCuenta"].Value, Convert.ToDouble(node.Attributes["Ayuda"].Value),
                    Convert.ToInt32(node.Attributes["FormaPago"].Value));
                listado.Add(nuevoSocio);
            }
            return listado;
        }
        private List<Perro> cargarPerros()
        {
            List<Perro> listado = new List<Perro>();
            // Cargar contenido de prueba
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(Directory.GetCurrentDirectory() + @"/Perros.xml");
            }
            catch (Exception)
            {
                var fichero = Application.GetResourceStream(new Uri("Ficheros/Perros.xml", UriKind.Relative));
                doc.Load(fichero.Stream);
            }

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                //Convert.ToDateTime(node.Attributes["FechaEntrada"].Value)
                var nuevoPerro = new Perro(node.Attributes["Nombre"].Value, Convert.ToInt32(node.Attributes["Sexo"].Value), node.Attributes["Raza"].Value,
                    Convert.ToDouble(node.Attributes["Peso"].Value), Convert.ToInt32(node.Attributes["Edad"].Value),
                    DateTime.Parse(node.Attributes["FechaEntrada"].Value), node.Attributes["Chip"].Value,
                    Convert.ToBoolean(node.Attributes["PPP"].Value), Convert.ToBoolean(node.Attributes["Vacunado"].Value),
                    Convert.ToBoolean(node.Attributes["Esterilizado"].Value), node.Attributes["Enfermedades"].Value,
                    new Uri(node.Attributes["Foto"].Value, UriKind.RelativeOrAbsolute), node.Attributes["Descripcion"].Value,
                    Convert.ToBoolean(node.Attributes["Sociable"].Value), Convert.ToInt32(node.Attributes["Estado"].Value),
                    generarPadrino(node.Attributes["Padrino"].Value));
                listado.Add(nuevoPerro);
            }
            return listado;
        }

        private Padrino generarPadrino(string p)
        {
            if (p.Equals(""))
            {
                return null;
            }
            else
            {
                foreach (Padrino pAux in Padrinos)
                {
                    string pa = pAux.Nombre + " " + pAux.Apellidos;
                    if (pa.Equals(p))
                    {
                        return pAux;
                    }
                }
            }
            return null;
        }


        private void Btn_Contrasenia_Click(object sender, RoutedEventArgs e)
        {
            mostrarCambioPass();

        }

        private void mostrarCambioPass()
        {
            Grid_Login.Visibility = Visibility.Collapsed;
            Grid_Contrasenia.Visibility = Visibility.Visible;
            txtbox_usuarioContra.Text = "";
            txtbox_usuarioContra.Focus();
            pss_nuevaContra.Password = "";
            pss_nuevaContra.IsEnabled = false;
            pss_codigo.Password = "";
            pss_codigo.IsEnabled = false;

            win_Preferencias.aplicarCambios();
        }

        private void btn_atras_Click(object sender, RoutedEventArgs e)
        {
            mostrarLogin();
        }

        private void btn_config_Click(object sender, RoutedEventArgs e)
        {
            win_Preferencias winPref = new win_Preferencias();
            winPref.Show();
            btn_config.IsEnabled = false;
            Win_Control.b_config_C.IsEnabled = false;
        }

        private void btn_ayuda_Click(object sender, RoutedEventArgs e)
        {
            win_Ayuda winAyu = new win_Ayuda(Ayudas);
            win_Preferencias.aplicarCambios();
            winAyu.Show();
            btn_ayuda.IsEnabled = false;
            Win_Control.b_ayuda_C.IsEnabled = false;
        }

        private void btn_acceder_Click(object sender, RoutedEventArgs e)
        {
            if (comprobarAdmin(txtbox_usuario.Text, adv_usuario_lo) && comprobarPass(pss_contra.Password, adv_contra_lo))
            {
                if (MainWindow.PConfig.Sonidos)
                {
                    //Uri u = new Uri("Sonidos/unLadrido.wav", UriKind.Relative);
                    //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                    //miSonido3.Play();
                    SystemSounds.Hand.Play();
                }
                //mostrar marco y ocultar login
                Win_Control.asignarUSuario(aAux);
                this.Visibility = Visibility.Collapsed;
                wMarco.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
            }

        }

        private void btn_cambiar_Click(object sender, RoutedEventArgs e)
        {
            if (comprobarAdmin(txtbox_usuarioContra.Text, adv_usuario_cc) && comprobarNoVacio(pss_nuevaContra.Password, adv_contra_cc) && comprobarCodigoAdmin(pss_codigo, adv_codigo_cc))
            {
                if (MainWindow.PConfig.Sonidos)
                {
                    //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                    //miSonido3.Play();
                    SystemSounds.Hand.Play();
                }

                mostrarLogin();
                MessageBox.Show("Contraseña actualizada exitosamente.", "Contraseña actualizada");
                //y cambiar contraseña
                aAux.Contrasenia = pss_nuevaContra.Password;
            }
            else
            {
                MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
                pss_nuevaContra.IsEnabled = true;
                pss_codigo.IsEnabled = true;
            }
        }


        private void btn_siguiente_Click(object sender, RoutedEventArgs e)
        {
            if (comprobarNoVacio(txt_nombre_AU.Text, adv_nombre_au) && comprobarNoVacio(txt_apellidos_AU.Text, adv_apellidos_au))
            {
                Grid_addUsuario_1.Visibility = Visibility.Collapsed;
                Grid_addUsuario_2.Visibility = Visibility.Visible;
                txt_usuario_AU.Focus();
            }
            else
            {
                MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
            }
        }

        private void btn_addUsuario_Click(object sender, RoutedEventArgs e)
        {
            Grid_addUsuario_1.Visibility = Visibility.Visible;
            Grid_Login.Visibility = Visibility.Collapsed;
            txt_nombre_AU.Text = "";
            txt_nombre_AU.Focus();
            txt_apellidos_AU.Text = "";
            txt_usuario_AU.Text = "";
            pss_Contra_AU.Password = "";

            win_Preferencias.aplicarCambios();
        }

        private void btn_atras_AU1_Click(object sender, RoutedEventArgs e)
        {
            mostrarLogin();
        }

        private void btn_atras_AU2_Click(object sender, RoutedEventArgs e)
        {
            Grid_addUsuario_1.Visibility = Visibility.Visible;
            Grid_addUsuario_2.Visibility = Visibility.Collapsed;
            txt_nombre_AU.Focus();
        }

        private void btn_registrar_Click(object sender, RoutedEventArgs e)
        {
            if (comprobarNoAdmin(txt_usuario_AU.Text, adv_usuario_au) && comprobarNoVacio(txt_usuario_AU.Text, adv_usuario_au) && comprobarNoVacio(pss_Contra_AU.Password, adv_contra_au) && comprobarCodigoAdmin(pss_codigo_AU, adv_codigo_au))
            {
                if (MainWindow.PConfig.Sonidos)
                {
                    //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/unLadrido.wav");
                    //miSonido3.Play();
                    SystemSounds.Hand.Play();
                }
                MessageBox.Show("Usuario registrado exitosamente.", "Usuario añadido");
                mostrarLogin();
                //y registrar
                Administradores.Add(new Administrador(txt_usuario_AU.Text, pss_Contra_AU.Password, txt_nombre_AU.Text, txt_apellidos_AU.Text));
            }
            else
            {
                MessageBox.Show("Corrige los campos con avisos.", "Valores incorrectos");
            }
        }

        public void mostrarLogin()
        {
            Grid_Contrasenia.Visibility = Visibility.Collapsed;
            Grid_addUsuario_1.Visibility = Visibility.Collapsed;
            Grid_addUsuario_2.Visibility = Visibility.Collapsed;
            Grid_Login.Visibility = Visibility.Visible;
            txtbox_usuario.Text = "";
            txtbox_usuario.Focus();
            pss_contra.Password = "";

            win_Preferencias.aplicarCambios();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            guardar();
            Application.Current.Shutdown();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MainWindow.PConfig.Sonidos)
            {
                //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/llanto_3seg.wav");
                //miSonido3.Play();
                SystemSounds.Hand.Play();
            }

            if (Grid_Login.Visibility != Visibility.Visible)
            {
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación sin terminar la acción?", "Confirmación", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        guardar();

                        Application.Current.Shutdown();
                        break;
                    case MessageBoxResult.No:
                        e.Cancel = true;
                        break;
                }
            }
            else
            {
                guardar();

                Application.Current.Shutdown();
            }
        }

        private void txtbox_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                pss_contra.Focus();
            }
        }
        private void pss_contra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btn_acceder.Focus();
            }
        }

        private bool comprobarAdmin(string usuario, Image i)
        {
            bool valido = false;
            foreach (Administrador admAux in Administradores)
            {
                if (admAux.Usuario.Equals(usuario))
                {
                    aAux = admAux;
                    valido = true;
                    break;
                }
            }
            if (valido)
            {
                comprobarControl(i, true);
                return true;
            }
            else
            {
                aAux = null;
                comprobarControl(i, false);
                return false;
            }
        }
        private bool comprobarNoAdmin(string usuario, Image i)
        {
            bool existente = false;
            foreach (Administrador admAux in Administradores)
            {
                if (admAux.Usuario.Equals(usuario))
                {
                    existente = true;
                    break;
                }
            }
            if (existente)
            {
                comprobarControl(i, false);
                return false;
            }
            else
            {
                comprobarControl(i, true);
                return true;
            }
        }
        private bool comprobarPass(string pass, Image i)
        {
            if (aAux.Contrasenia.Equals(pass))
            {
                comprobarControl(i, true);
                return true;
            }
            else
            {
                comprobarControl(i, false);
                return false;
            }
        }

        private void comprobarControl(Image c, bool valido)
        {
            if (valido)
            {
                c.Visibility = Visibility.Collapsed;
            }
            else
            {
                c.Visibility = Visibility.Visible;
            }
        }

        private void txtbox_usuarioContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (comprobarAdmin(txtbox_usuarioContra.Text, adv_usuario_cc))
                {
                    pss_nuevaContra.IsEnabled = true;
                    pss_nuevaContra.Focus();
                    pss_codigo.IsEnabled = true;
                }
            }
        }

        private void pss_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (comprobarCodigoAdmin(pss_codigo, adv_codigo_cc))
                {
                    btn_cambiar.IsEnabled = true;
                    btn_cambiar.Focus();
                }
            }
        }

        private bool comprobarCodigoAdmin(PasswordBox pb, Image i)
        {
            if (pb.Password.Equals(codigoAdmin))
            {
                comprobarControl(i, true);
                return true;
            }
            else
            {
                comprobarControl(i, false);
                return false;
            }
        }

        public static bool comprobarNoVacio(string cadena, Image c)
        {

            if (cadena.Equals(""))
            {
                c.Visibility = Visibility.Visible;
                return false;
            }
            else
            {
                c.Visibility = Visibility.Collapsed;
                return true;
            }
        }

        private void pss_nuevaContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                comprobarNoVacio(pss_nuevaContra.Password, adv_contra_cc);
                pss_codigo.Focus();
            }
        }

        private void txtbox_usuario_DragEnter(object sender, DragEventArgs e)
        {
            pss_contra.Focus();
        }

        private void gif_main_MouseEnter(object sender, MouseEventArgs e)
        {
            if (MainWindow.PConfig.Sonidos)
            {
                //SoundPlayer miSonido3 = new SoundPlayer(Directory.GetCurrentDirectory() + @"/ladridosCachorro.wav");
                //miSonido3.Play();
                //SystemSounds.Hand.Play();
            }
        }

        private void txt_nombre_AU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                comprobarNoVacio(txt_nombre_AU.Text, adv_nombre_au);
                txt_apellidos_AU.Focus();
            }
        }

        private void txt_apellidos_AU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                comprobarNoVacio(txt_apellidos_AU.Text, adv_apellidos_au);
                btn_siguiente.Focus();
            }
        }

        private void txt_usuario_AU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                comprobarNoAdmin(txt_usuario_AU.Text, adv_usuario_au);
                comprobarNoVacio(txt_usuario_AU.Text, adv_usuario_au);
                pss_Contra_AU.Focus();
            }
        }

        private void pss_Contra_AU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                comprobarNoVacio(pss_Contra_AU.Password, adv_contra_au);
                pss_codigo_AU.Focus();
            }
        }

        private void pss_codigo_AU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                comprobarCodigoAdmin(pss_codigo_AU, adv_codigo_au);
                btn_registrar.Focus();
            }
        }

        public static void escribirXMLPerros()
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Perros");
            xmlDoc.AppendChild(rootNode);

            XmlNode perroNodo;
            XmlAttribute atributo;

            foreach (Perro p in Perros)
            {
                perroNodo = xmlDoc.CreateElement("Perro");
                atributo = xmlDoc.CreateAttribute("Nombre");
                atributo.Value = p.Nombre;
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Sexo");
                atributo.Value = p.Sexo.ToString();
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Raza");
                atributo.Value = p.Raza;
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Peso");
                atributo.Value = p.Peso.ToString();
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Edad");
                atributo.Value = p.Edad.ToString();
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("FechaEntrada");
                atributo.Value = p.FechaEntrada.ToString();
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Chip");
                atributo.Value = p.Chip;
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("PPP");
                atributo.Value = p.Ppp.ToString();
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Vacunado");
                atributo.Value = p.Vacunado.ToString();
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Esterilizado");
                atributo.Value = p.Esterilizado.ToString();
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Enfermedades");
                atributo.Value = p.Enfermedades;
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Foto");
                atributo.Value = p.Foto.OriginalString;
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Descripcion");
                atributo.Value = p.Descripcion;
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Sociable");
                atributo.Value = p.Sociable.ToString();
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Estado");
                atributo.Value = p.Estado.ToString();
                perroNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Padrino");
                if (p.Padr == null)
                {
                    atributo.Value = "-1";
                }
                else
                {
                    atributo.Value = p.Padr.Nombre + " " + p.Padr.Apellidos;
                }
                perroNodo.Attributes.Append(atributo);

                rootNode.AppendChild(perroNodo);
            }
            xmlDoc.Save("Perros.xml");
        }

        public static void escribirXMLPadrinos()
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Padrinos");
            xmlDoc.AppendChild(rootNode);

            XmlNode padrinoNodo;
            XmlAttribute atributo;

            foreach (Padrino p in Padrinos)
            {
                padrinoNodo = xmlDoc.CreateElement("Padrino");
                atributo = xmlDoc.CreateAttribute("Nombre");
                atributo.Value = p.Nombre;
                padrinoNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Apellidos");
                atributo.Value = p.Apellidos;
                padrinoNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Telefono");
                atributo.Value = p.Telefono;
                padrinoNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("AportacionMensual");
                atributo.Value = p.AportacionMensual.ToString();
                padrinoNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("FormaPago");
                atributo.Value = p.FormaPago.ToString();
                padrinoNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Cuenta");
                atributo.Value = p.NumeroCuenta;
                padrinoNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("FechaComienzoApadrinamiento");
                atributo.Value = p.FechaComienzoApadrinamiento.ToString();
                padrinoNodo.Attributes.Append(atributo);


                rootNode.AppendChild(padrinoNodo);
            }
            xmlDoc.Save("Padrinos.xml");
        }

        public static void escribirXMLSocios()
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Socios");
            xmlDoc.AppendChild(rootNode);

            XmlNode socioNodo;
            XmlAttribute atributo;

            foreach (Socio s in Socios)
            {
                socioNodo = xmlDoc.CreateElement("Socio");
                atributo = xmlDoc.CreateAttribute("Nombre");
                atributo.Value = s.Nombre;
                socioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Apellidos");
                atributo.Value = s.Apellidos;
                socioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Correo");
                atributo.Value = s.Correo;
                socioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("TitularCuenta");
                atributo.Value = s.TitularCuenta;
                socioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("NumeroCuenta");
                atributo.Value = s.NumeroCuenta;
                socioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Ayuda");
                atributo.Value = s.CuantiaAyuda.ToString();
                socioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("FormaPago");
                atributo.Value = s.FormaPago.ToString();
                socioNodo.Attributes.Append(atributo);

                rootNode.AppendChild(socioNodo);
            }
            xmlDoc.Save("Socios.xml");
        }

        public static void escribirXMLVoluntarios()
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Voluntarios");
            xmlDoc.AppendChild(rootNode);

            XmlNode voluntarioNodo;
            XmlAttribute atributo;

            foreach (Voluntario v in Voluntarios)
            {
                voluntarioNodo = xmlDoc.CreateElement("Voluntario");
                atributo = xmlDoc.CreateAttribute("Nombre");
                atributo.Value = v.Nombre;
                voluntarioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Apellidos");
                atributo.Value = v.Apellidos;
                voluntarioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Correo");
                atributo.Value = v.Correo;
                voluntarioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("DNI");
                atributo.Value = v.Dni;
                voluntarioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Telefono");
                atributo.Value = v.Telefono;
                voluntarioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Foto");
                atributo.Value = v.Foto.OriginalString;
                voluntarioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("HorarioDisponibilidad");
                atributo.Value = v.HorarioDisponibilidad;
                voluntarioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("ZonaActuacion");
                atributo.Value = v.ZonaActuacion;
                voluntarioNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("ConocimientosVeterinarios");
                atributo.Value = v.ConocimientosVeterinarios.ToString();
                voluntarioNodo.Attributes.Append(atributo);

                rootNode.AppendChild(voluntarioNodo);
            }

            xmlDoc.Save("Voluntarios.xml");
        }

        public static void escribirXMLAdmins()
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Administradores");
            xmlDoc.AppendChild(rootNode);

            XmlNode adminNodo;
            XmlAttribute atributo;

            foreach (Administrador a in Administradores)
            {
                adminNodo = xmlDoc.CreateElement("Administrador");
                atributo = xmlDoc.CreateAttribute("Usuario");
                atributo.Value = a.Usuario;
                adminNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Contrasenia");
                atributo.Value = a.Contrasenia;
                adminNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Nombre");
                atributo.Value = a.Nombre;
                adminNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("Apellidos");
                atributo.Value = a.Apellidos;
                adminNodo.Attributes.Append(atributo);
                atributo = xmlDoc.CreateAttribute("UltimoAcceso");
                atributo.Value = a.UltimoAcceso.ToString();
                adminNodo.Attributes.Append(atributo);

                rootNode.AppendChild(adminNodo);
            }

            xmlDoc.Save("Administradores.xml");
        }

        public static void escribirXMLConfig()
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Preferencias");
            xmlDoc.AppendChild(rootNode);

            XmlNode configNodo;
            XmlAttribute atributo;

            configNodo = xmlDoc.CreateElement("Preferencia");
            atributo = xmlDoc.CreateAttribute("Scroll");
            atributo.Value = PConfig.Scroll.ToString();
            configNodo.Attributes.Append(atributo);
            atributo = xmlDoc.CreateAttribute("TBotones");
            atributo.Value = PConfig.TBotones.ToString();
            configNodo.Attributes.Append(atributo);
            atributo = xmlDoc.CreateAttribute("TFuentes");
            atributo.Value = PConfig.TFuentes.ToString();
            configNodo.Attributes.Append(atributo);
            atributo = xmlDoc.CreateAttribute("TIconos");
            atributo.Value = PConfig.TIconos.ToString();
            configNodo.Attributes.Append(atributo);
            atributo = xmlDoc.CreateAttribute("TemaClaro");
            atributo.Value = PConfig.Tema.ToString();
            configNodo.Attributes.Append(atributo);
            atributo = xmlDoc.CreateAttribute("Gif");
            atributo.Value = PConfig.Gif.ToString();
            configNodo.Attributes.Append(atributo);
            atributo = xmlDoc.CreateAttribute("Sonidos");
            atributo.Value = PConfig.Sonidos.ToString();
            configNodo.Attributes.Append(atributo);

            rootNode.AppendChild(configNodo);

            xmlDoc.Save("Preferencias.xml");
        }

        public static void guardar()
        {

            escribirXMLPerros();
            escribirXMLPadrinos();
            escribirXMLSocios();
            escribirXMLVoluntarios();
            escribirXMLAdmins();
            escribirXMLConfig();

        }
    }
}

