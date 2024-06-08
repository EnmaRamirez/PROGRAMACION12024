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

namespace PracBaseAlumno
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            recoverData();
        }
        private void recoverData(){
            DataAccess dataAccess = new DataAccess();
            List<Alumno> alumnosConDapper = dataAccess.GetAllDapper();
            myDataGrid.ItemsSource = alumnosConDapper;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InsertWindow insertWindow = new InsertWindow();
            insertWindow.Show();
            insertWindow.Closed += Window_Closed; ;

             
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            recoverData();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = ((Alumno)myDataGrid.SelectedItem).Id;
            UpdateWindow updateWindow = new UpdateWindow(id);
            updateWindow.Show();
            updateWindow.Closed += Window_Closed;

        }
    }
}
