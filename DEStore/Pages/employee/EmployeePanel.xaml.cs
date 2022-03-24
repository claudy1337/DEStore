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

namespace DEStore.Pages.employee
{
    /// <summary>
    /// Логика взаимодействия для EmployeePanel.xaml
    /// </summary>
    public partial class EmployeePanel : Page
    {
        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void BOrders_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new Pages.FullOrders());
        }

        private void BTakeOrder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.employee.TakeOrders());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.auth());
        }

        private void BWarehouse_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Warehouse());
        }
    }
}
