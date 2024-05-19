using System;
using System.Collections.Generic;
using System.IO;
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

namespace FormatoArchivoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CargarDesdeArchivo_Click(object sender, RoutedEventArgs e)
        {
            string rutaArchivo = txtRutaArchivo.Text;

            if (File.Exists(rutaArchivo))
            {
                lbJuego.ItemsSource = LeerJuegosDesdeArchivo(rutaArchivo);
            }
            else
            {
                MessageBox.Show("El archivo especificado no existe.");
            }
        }

        private List<Juego> LeerJuegosDesdeArchivo(string rutaArchivo)
        {
            List<Juego> juegos = new List<Juego>();

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');

                        if (datos.Length == 5)
                        {
                            Juego juego = new Juego
                            {
                                Eq1 = datos[0],
                                Eq2 = datos[1],
                                Puntaje1 = int.Parse(datos[2]),
                                Puntaje2 = int.Parse(datos[3]),
                                Progreso = int.Parse(datos[4])
                            };
                            juegos.Add(juego);
                        }
                        else
                        {
                            MessageBox.Show("Formato de línea incorrecto en el archivo.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }

            return juegos;
        }
    }
}
