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

namespace PracBaseVenta
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
            List<Venta> ventasConDapper = dataAccess.GetAllDapper();
            myDataGrid.ItemsSource = ventasConDapper;

            //DataAccess dataAccess = new DataAccess();
            //List<Venta> ventas = dataAccess.GetAllAdoNet();
            //string resultados = "";
            //foreach (var item in ventas)
            //{
            // resultados += item.Id + " " + item.Cliente + "\n";

            //}
            //MessageBox.Show(resultados);

            //List<Venta> ventasConDapper = dataAccess.GetAllDapper();
            //string resultadosConDapper = "";
            //foreach (var item in ventasConDapper)
            //{
            //resultadosConDapper += item.Id + " " + item.Cliente + "\n";
            // }
            //MessageBox.Show(resultadosConDapper);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            InsertWindow insertWindow = new InsertWindow();
            insertWindow.Show();
            
        }
    }
}