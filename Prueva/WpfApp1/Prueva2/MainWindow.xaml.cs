using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Prueva2
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

        private void LoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            string filePath = txtFilePath.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            List<Juego> juegos = new List<Juego>();

            try
            {
                // Lee las líneas del archivo
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    
                    string[] parts = line.Split(',');

                  
                    if (parts.Length >= 5)
                    {
                        // nuevo juego y asignar valores
                        Juego juego = new Juego
                        {
                            Eq1 = parts[0],
                            Puntaje1 = int.Parse(parts[1]),
                            Puntaje2 = int.Parse(parts[2]),
                            Eq2 = parts[3],
                            Progreso = int.Parse(parts[4])
                        };

                        // Agrega el juego a la lista
                        juegos.Add(juego);
                    }
                    else
                    {
                        // Línea incorrecta, omite esta línea
                        continue;
                    }
                }

                // Actualiza la lista de juegos en la vista
                lbJuego.ItemsSource = juegos;

                MessageBox.Show("Datos cargados desde el archivo correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos desde el archivo: " + ex.Message);
            }
        }
    }
}



