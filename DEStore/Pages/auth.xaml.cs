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
using System.Collections.ObjectModel;

namespace DEStore.Pages
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Page
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();


        public auth()
        {
            InitializeComponent();
        }

        private void BSignUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.registration());
        }

        private void BSignIn_Click(object sender, RoutedEventArgs e)
        {
            Model.user users = db.user.FirstOrDefault(u => u.loginUser == TBLogin.Text && u.passwordUser == TBPassword.Password && u.numberUser == TBNumber.Text);
            Model.admin admins = db.admin.FirstOrDefault(a => a.loginAdmin == TBLogin.Text && a.passwordAdmin == TBPassword.Password && a.number == TBNumber.Text);
           // Model.employee employees = db.employee.FirstOrDefault(s => s.loginEmployee == TBLogin.Text && s.passwordEmployee == TBPassword.Password && s.number == Convert.ToInt32(TBNumber.Text));
            if (users != null )
            {
                MessageBox.Show("welcome " + users.fullNameUser);
                NavigationService.Navigate(new Pages.user.Store());
                MainWindow.LoggedUser = users;
                return;
            }
            else if(admins !=null)
            {
                MessageBox.Show("welcome admin");
                NavigationService.Navigate(new Pages.AdminsPanel());
                return;
            }
           
            else
            {
                MessageBox.Show("unkown");
            }
            
        }
    }
}
