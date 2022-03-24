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
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class Products : Page
    {
        public Products()
        {
            InitializeComponent();
        }

        private void BInStockProducts_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.InStockProducts());
        }

        private void BAddProducts_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Pages.AddProducts());
        }

        private void BDeleteProducts_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.DeleteProducts());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AdminsPanel());
        }
    }
}
