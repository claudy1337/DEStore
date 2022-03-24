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
    /// Логика взаимодействия для AdminsPanel.xaml
    /// </summary>
    public partial class AdminsPanel : Page
    {
        public AdminsPanel()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.auth());
        }

        private void BWorkEmployee_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.WorksEmployee());
        }

        private void BEmployeeEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.EmployeeEdit());
        }

        

        private void BProducts_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Products());
        }

        private void Bpoint_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Point());
        }
    }
}
