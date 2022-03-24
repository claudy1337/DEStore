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

namespace DEStore.Pages
{
    /// <summary>
    /// Логика взаимодействия для Warehouse.xaml
    /// </summary>
    public partial class Warehouse : Page
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();

        public Warehouse()
        {
            InitializeComponent();
            Refresh();
        }
        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void myDataGrids_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Refresh()
        {
            myDataGrids.ItemsSource = db.order.ToList();
            myDataGrids.ItemsSource = db.order.Where(c => c.statusOrder.ToString() == "False").ToList();
        }
    }
}
