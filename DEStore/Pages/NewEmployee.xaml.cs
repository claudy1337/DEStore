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
    /// Логика взаимодействия для NewEmployee.xaml
    /// </summary>
    public partial class NewEmployee : Page
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();

        public NewEmployee()
        {
            InitializeComponent();
        }

        private void BCreateEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBLogin.Text) || string.IsNullOrWhiteSpace(TBPassword.Text) || string.IsNullOrWhiteSpace(TBName.Text) || string.IsNullOrWhiteSpace(TBNumber.Text))
            {
                MessageBox.Show("incorrect");
                return;
            }
            Model.employee employees = new Model.employee() { loginEmployee = TBLogin.Text, passwordEmployee = TBPassword.Text, number = Convert.ToInt32(TBNumber.Text), fullNameEmployee = TBName.Text };
            db.employee.Add(employees);
            db.SaveChanges();
            MessageBox.Show("ok");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AdminsPanel());
        }
    }
}
