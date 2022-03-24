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
    /// Логика взаимодействия для EmployeeEdit.xaml
    /// </summary>
    public partial class EmployeeEdit : Page
    {
        public EmployeeEdit()
        {
            InitializeComponent();
        }

        private void BNewEmployee_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.NewEmployee());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AdminsPanel());
        }

        

        private void BEmployeeDelete_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.DeleteEmployee());
        }

        private void BDismiss_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
