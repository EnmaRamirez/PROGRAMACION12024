using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiCrud
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadAlumnos();
        }
        private void LoadAlumnos()
        {
            DataTable alumnos = DataAccess.GetAlumnos();
            AlumnosDataGrid.ItemsSource = alumnos.DefaultView;
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            CrearAlumno createAlumno = new CrearAlumno();
            createAlumno.ShowDialog();
            LoadAlumnos();
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            if (AlumnosDataGrid.SelectedItem != null)
            {
                DataRowView row = (DataRowView)AlumnosDataGrid.SelectedItem;
                int carnet = (int)row["Carnet"];
                string nombre = (string)row["Nombre"];
                string telefono = (string)row["Telefono"];
                string grado = (string)row["Grado"];
                int usuarioID = (int)row["UsuarioID"];

                UpdateAlumno updateAlumno = new UpdateAlumno(carnet, nombre, telefono, grado, usuarioID);
                updateAlumno.ShowDialog();
                LoadAlumnos();
            }

        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (AlumnosDataGrid.SelectedItem != null)
            {
                DataRowView row = (DataRowView)AlumnosDataGrid.SelectedItem;
                int carnet = (int)row["Carnet"];

                DataAccess.DeleteAlumno(carnet);
                LoadAlumnos();
            }
        }
    }
}
