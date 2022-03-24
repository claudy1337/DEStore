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
    /// Логика взаимодействия для registration.xaml
    /// </summary>
    public partial class registration : Page
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();

        public registration()
        {
            InitializeComponent();
            TBLogin.MaxLength = 7;
            TBName.MaxLength = 15;
            TBPassword.MaxLength = 15;
            TBNumber.MaxLength = 7;


        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {
            Model.admin admins = new Model.admin();
            Model.employee employees = new Model.employee();
            if(string.IsNullOrWhiteSpace(TBLogin.Text) || string.IsNullOrWhiteSpace(TBPassword.Text) || string.IsNullOrWhiteSpace(TBName.Text) || string.IsNullOrWhiteSpace(TBNumber.Text) || TBLogin.Text != admins.loginAdmin || TBLogin.Text != employees.loginEmployee && TBPassword.Text != employees.passwordEmployee)
            {
                MessageBox.Show("incorrect");
                return;
            }
            bool isUnical = true;
            foreach(var user in db.user)
            {
                if(user.loginUser == TBLogin.Text)
                {
                    isUnical = false;
                }
            }
            if(isUnical)
            {
                Model.user users = new Model.user() { loginUser = TBLogin.Text, passwordUser = TBPassword.Text, spentUser = 0, numberUser = TBNumber.Text, fullNameUser = TBName.Text };
                db.user.Add(users);
                db.SaveChanges();
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("error");
            }
            

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {
            
            TBLogin.Text = "";
            TBPassword.Text = "";
            TBNumber.Text = "";
        }

        private void TBLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
