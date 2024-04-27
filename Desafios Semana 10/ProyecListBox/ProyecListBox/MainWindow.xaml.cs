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

namespace ProyecListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Juego> juegos;
        public MainWindow()
        {
            InitializeComponent();
            juegos = new List<Juego>();
            lbJuego.ItemsSource = juegos;

        }
        private void Button_Cargar_Click(object sender, RoutedEventArgs e)
        {
            string filePath = txtFilepath.Text;

            try
            {
                juegos.Clear(); // Limpia la lista antes de cargar nuevos datos

                // Lee el contenido del archivo de texto línea por línea
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    // Divide cada línea por comas para obtener los datos de juego
                    string[] data = line.Split(',');

                    // Crea una instancia de Juego y agrega a la lista
                    Juego juego = new Juego()
                    {
                        Eq1 = data[0].Trim(),
                        Eq2 = data[1].Trim(),
                        Puntaje1 = int.Parse(data[2].Trim()),
                        Puntaje2 = int.Parse(data[3].Trim()),
                        Progreso = int.Parse(data[4].Trim())
                    };
                    juegos.Add(juego);
                }

                // Notifica al ListBox que los datos han cambiado
                lbJuego.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message);
            }
        }


    }   
    
}