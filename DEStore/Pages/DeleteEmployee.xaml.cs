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
    /// Логика взаимодействия для DeleteEmployee.xaml
    /// </summary>
    public partial class DeleteEmployee : Page
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();

        public DeleteEmployee()
        {
            InitializeComponent();
            Refresh();
        }

       

        private void BRemove_Click(object sender, RoutedEventArgs e)
        {
            if(DGEmployee.SelectedItem == null)
            {
                MessageBox.Show("select item");
                return;
            }
            db.employee.Remove((Model.employee)DGEmployee.SelectedItem);
            db.SaveChanges();
            Refresh();
        }
        private void Refresh()
        {
            DGEmployee.ItemsSource = null;
            DGEmployee.ItemsSource = db.employee.ToList();

        }

        private void DGEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
