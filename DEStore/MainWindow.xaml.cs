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

namespace DEStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();

        public static Model.user LoggedUser = new Model.user();

        public MainWindow()
        {
            InitializeComponent();
            Autho.NavigationService.Navigate(new Pages.auth());
        }
    }
}
