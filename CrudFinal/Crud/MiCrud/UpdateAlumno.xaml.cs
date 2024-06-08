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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace MiCrud
{
    /// <summary>
    /// Lógica de interacción para UpdateAlumno.xaml
    /// </summary>
    public partial class UpdateAlumno : Window
    {
        private int carnet;
        
        public UpdateAlumno()
            
        {
            InitializeComponent();
            
        }
        public UpdateAlumno(int carnet, string nombre, string telefono, string grado, int usuarioID)
        {
            InitializeComponent();
            this.carnet = carnet;
            NombreTextBox.Text = nombre;
            TelefonoTextBox.Text = telefono;
            GradoTextBox.Text = grado;
            LoadUsuarios();
            UsuarioComboBox.SelectedValue = usuarioID;
        }
        private void LoadUsuarios()
        {
            DataTable usuarios = DataAccess.GetUsuarios();
            UsuarioComboBox.ItemsSource = usuarios.DefaultView;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string nombre = NombreTextBox.Text;
            string telefono = TelefonoTextBox.Text;
            string grado = GradoTextBox.Text;
            int usuarioID = (int)UsuarioComboBox.SelectedValue;

            DataAccess.UpdateAlumno(carnet, nombre, telefono, grado, usuarioID);
            this.Close();

        }

        private void Actualizar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = NombreTextBox.Text;
            string telefono = TelefonoTextBox.Text;
            string grado = GradoTextBox.Text;
            int usuarioID = (int)UsuarioComboBox.SelectedValue;

            DataAccess.UpdateAlumno(carnet, nombre, telefono, grado, usuarioID);
            this.Close();

        }
    }
}
